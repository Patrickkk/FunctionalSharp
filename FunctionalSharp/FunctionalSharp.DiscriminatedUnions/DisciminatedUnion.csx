var maxNumberOfTypes = 10;

public string TypeArgumentsFor(int numberOfArguments)
{
    return ArgumentsFor("Type{0}, ", numberOfArguments);
}

public string FunctionArgumentsFor(int numberOfArguments)
{
    return ArgumentsFor("Func<Type{0}, ReturnType> Function{0}, ", numberOfArguments);
}

public string ActionArgumentsFor(int numberOfArguments)
{
    return ArgumentsFor("Action<Type{0}> action{0}, ", numberOfArguments);
}

public string ArgumentsFor(string format, int numberOfArguments, int start = 0)
{
    var result = "";
    for (var i = start; i < numberOfArguments; i += 1)
    {
        result += String.Format(format, i + 1);
    }
    return result.Trim(' ').Trim(',');
}

public string FormatJoinedFor(string format, char seperator, int numberOfArguments, int start = 0)
{
    var result = "";
    for (var i = start; i < numberOfArguments; i += 1)
    {
        result += String.Format(format, i + 1);
    }
    return result.Trim(' ').Trim(seperator).Trim();
}

public string TypeParamsFor(int numberOfArguments, int start = 0)
{
    return CommentsFor("        /// <typeparam name=\"Type{0}\">Type{0}</typeparam>", numberOfArguments, start);
}

public string CommentsFor(string format, int numberOfArguments, int start = 0)
{
    var result = "";
    for (var i = start; i < numberOfArguments - 1; i += 1)
    {
        result += String.Format(format, i + 1);
        result += Environment.NewLine;
    }
    result += String.Format(format, numberOfArguments);
    return result;
}

public void WritePaths(ScriptContext context)
{
    context.Output.WriteLine($"Script File: {context.ScriptFilePath}");
    context.Output.WriteLine($"Project File: {context.ProjectFilePath}");
}

public void WriteRepeated(string template, int numberOfParameters)
{
    for (int i = 0; i < numberOfParameters; i++)
    {
        var output = template.Replace("{i}", i.ToString())
            .Replace("{i+1}", (i + 1).ToString())
            .Replace("{i + 1}", (i + 1).ToString())
            .Replace("{i-1}", (i + 1).ToString())
            .Replace("{i - 1}", (i + 1).ToString());
        Context.Output.WriteLine(output);
    }
}

public void WriteRepeated(int numberOfParameters, Func<int, string> templateConstructor)
{
    for (int i = 0; i < numberOfParameters; i++)
    {
        Context.Output.WriteLine(templateConstructor(i));
    }
}

public void WriteRepeated(int numberOfParameters, Func<int, string> firstTemplateConstructor, Func<int, string> repeatedTemplateConstructor)
{
    for (int i = 0; i < numberOfParameters; i++)
    {
        if (i == 0)
        {
            Context.Output.WriteLine(firstTemplateConstructor(i));
        }
        else
        {
            Context.Output.WriteLine(repeatedTemplateConstructor(i));
        }
    }
}

Context.Output.WriteLine(
@"namespace FunctionalSharp.DiscriminatedUnions
{
	using System;");
for (int unionTypeCount = 2; unionTypeCount <= maxNumberOfTypes; unionTypeCount++)
{
    Context.Output.WriteLine(
@"	/// <summary>
	/// A Discriminated union for <<NumberOfTypes>> types.
	/// </summary>");

    WriteRepeated(@"    /// <typeparam name=""Type{i+1}"">Type{i}</typeparam>", unionTypeCount);
    Context.Output.WriteLine(
@"	public class DiscriminatedUnion<" + TypeArgumentsFor(unionTypeCount) + @">
	{
		/// <summary>
		/// Private constructor to support serialization.
		/// </summary>
		protected DiscriminatedUnion() { }

		/// <summary>
		/// The tag indicating what item is actually stored.
		/// </summary>
		protected int tag;

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		public DiscriminatedUnion(object value)
		{");
    WriteRepeated(unionTypeCount,
        x => @"			if(value.GetType() == typeof(Type1))
			{
                Item" + (x + 1).ToString() + @" = (Type1)value;
				tag = " + x + @";
			}",
        x => @"			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}");
    Context.Output.WriteLine(@"			else
			{
				throw new ArgumentOutOfRangeException(""Unrecognized tag value: "" + tag);
			}
		}");

    WriteRepeated(@"
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name=""Type1""/>
		/// </summary>
		/// <param name=""item""></param>
		public DiscriminatedUnion(Type{i+1} item) { Item{i+1} = item; tag = {i}; }", unionTypeCount);
    WriteRepeated(@"
		/// <summary>
		/// The storage for type{i+1}.
		/// </summary>
		protected readonly Type{i+1} Item{i+1};", unionTypeCount);
    WriteRepeated(@"
        /// <summary>
        /// Conversion from Type{i+1} to the Discriminated union
        /// </summary>
        /// <param name=""value""></param>
        public static implicit operator DiscriminatedUnion<" + TypeArgumentsFor(unionTypeCount) + @">(Type{i+1} value)
        {
            return new DiscriminatedUnion<" + TypeArgumentsFor(unionTypeCount) + @">(value);
        }", unionTypeCount);
    Context.Output.WriteLine(@"
		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>");
    WriteRepeated(@"		/// <param name=""action{i+1}"">Action to run for <typeparamref name=""Type{i+1}""/></param>", unionTypeCount);
    Context.Output.WriteLine(@"        public void Match(" + ActionArgumentsFor(unionTypeCount) + @")
		{");
    WriteRepeated(@"			if(action{i+1} == null)
			{
				throw new ArgumentNullException(""The argument action{i+1} is null"");
			}", unionTypeCount);
    Context.Output.WriteLine(@"
            switch (tag)
			{");

    WriteRepeated(@"				case {i}: action{i+1}(Item{i+1}); break;", unionTypeCount);
    Context.Output.WriteLine(@"                default: throw new ArgumentOutOfRangeException(""Unrecognized tag value: "" + tag);
			}
		}
	}");
}
Context.Output.WriteLine(
@"
}");
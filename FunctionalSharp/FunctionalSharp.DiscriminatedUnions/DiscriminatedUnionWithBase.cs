namespace FunctionalSharp.DiscriminatedUnions
{
	using System;
	using System.ComponentModel;

	/// <summary>
	/// A Discriminated union for 2 types.
	/// </summary>
	/// <typeparam name="Type1">Type1</typeparam>
	/// <typeparam name="Type2">Type2</typeparam>
    /// <typeparam name="BaseType"></typeparam>
	[Serializable]
	public class DiscriminatedUnionWithBase<Type1, Type2, BaseType> : DiscriminatedUnion<Type1, Type2>
		where Type1 : BaseType 
		where Type2 : BaseType 
	{
		/// <summary>
		/// Private constructor to support serialization.
		/// </summary>
		private DiscriminatedUnionWithBase() : base() { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type2 item) : base(item) { }

		/// <summary>
		/// Gets any type by returning the basetype.
		/// </summary>
		/// <returns>Any type as the BaseType</returns>
		public BaseType AnyType
		{
			get
			{
				switch (tag)
				{
					case 0: return Item1;
					case 1: return Item2;
					default: throw new System.NotSupportedException("Unrecognized tag value: " + tag);
				}
			}
		}
	}
	/// <summary>
	/// A Discriminated union for 3 types.
	/// </summary>
	/// <typeparam name="Type1">Type1</typeparam>
	/// <typeparam name="Type2">Type2</typeparam>
	/// <typeparam name="Type3">Type3</typeparam>
    /// <typeparam name="BaseType"></typeparam>
	[Serializable]
	public class DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType> : DiscriminatedUnion<Type1, Type2, Type3>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
	{
		/// <summary>
		/// Private constructor to support serialization.
		/// </summary>
		private DiscriminatedUnionWithBase() : base() { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type3 item) : base(item) { }

		/// <summary>
		/// Gets any type by returning the basetype.
		/// </summary>
		/// <returns>Any type as the BaseType</returns>
		public BaseType AnyType
		{
			get
			{
				switch (tag)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					default: throw new System.NotSupportedException("Unrecognized tag value: " + tag);
				}
			}
		}
	}
	/// <summary>
	/// A Discriminated union for 4 types.
	/// </summary>
	/// <typeparam name="Type1">Type1</typeparam>
	/// <typeparam name="Type2">Type2</typeparam>
	/// <typeparam name="Type3">Type3</typeparam>
	/// <typeparam name="Type4">Type4</typeparam>
    /// <typeparam name="BaseType"></typeparam>
	[Serializable]
	public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 
	{
		/// <summary>
		/// Private constructor to support serialization.
		/// </summary>
		private DiscriminatedUnionWithBase() : base() { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type4 item) : base(item) { }

		/// <summary>
		/// Gets any type by returning the basetype.
		/// </summary>
		/// <returns>Any type as the BaseType</returns>
		public BaseType AnyType
		{
			get
			{
				switch (tag)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					default: throw new System.NotSupportedException("Unrecognized tag value: " + tag);
				}
			}
		}
	}
	/// <summary>
	/// A Discriminated union for 5 types.
	/// </summary>
	/// <typeparam name="Type1">Type1</typeparam>
	/// <typeparam name="Type2">Type2</typeparam>
	/// <typeparam name="Type3">Type3</typeparam>
	/// <typeparam name="Type4">Type4</typeparam>
	/// <typeparam name="Type5">Type5</typeparam>
    /// <typeparam name="BaseType"></typeparam>
	[Serializable]
	public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 
		where Type5 : BaseType 
	{
		/// <summary>
		/// Private constructor to support serialization.
		/// </summary>
		private DiscriminatedUnionWithBase() : base() { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type5 item) : base(item) { }

		/// <summary>
		/// Gets any type by returning the basetype.
		/// </summary>
		/// <returns>Any type as the BaseType</returns>
		public BaseType AnyType
		{
			get
			{
				switch (tag)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					default: throw new System.NotSupportedException("Unrecognized tag value: " + tag);
				}
			}
		}
	}
	/// <summary>
	/// A Discriminated union for 6 types.
	/// </summary>
	/// <typeparam name="Type1">Type1</typeparam>
	/// <typeparam name="Type2">Type2</typeparam>
	/// <typeparam name="Type3">Type3</typeparam>
	/// <typeparam name="Type4">Type4</typeparam>
	/// <typeparam name="Type5">Type5</typeparam>
	/// <typeparam name="Type6">Type6</typeparam>
    /// <typeparam name="BaseType"></typeparam>
	[Serializable]
	public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 
		where Type5 : BaseType 
		where Type6 : BaseType 
	{
		/// <summary>
		/// Private constructor to support serialization.
		/// </summary>
		private DiscriminatedUnionWithBase() : base() { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type5 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type6"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type6 item) : base(item) { }

		/// <summary>
		/// Gets any type by returning the basetype.
		/// </summary>
		/// <returns>Any type as the BaseType</returns>
		public BaseType AnyType
		{
			get
			{
				switch (tag)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					default: throw new System.NotSupportedException("Unrecognized tag value: " + tag);
				}
			}
		}
	}
	/// <summary>
	/// A Discriminated union for 7 types.
	/// </summary>
	/// <typeparam name="Type1">Type1</typeparam>
	/// <typeparam name="Type2">Type2</typeparam>
	/// <typeparam name="Type3">Type3</typeparam>
	/// <typeparam name="Type4">Type4</typeparam>
	/// <typeparam name="Type5">Type5</typeparam>
	/// <typeparam name="Type6">Type6</typeparam>
	/// <typeparam name="Type7">Type7</typeparam>
    /// <typeparam name="BaseType"></typeparam>
	[Serializable]
	public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 
		where Type5 : BaseType 
		where Type6 : BaseType 
		where Type7 : BaseType 
	{
		/// <summary>
		/// Private constructor to support serialization.
		/// </summary>
		private DiscriminatedUnionWithBase() : base() { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type5 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type6"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type6 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type7"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type7 item) : base(item) { }

		/// <summary>
		/// Gets any type by returning the basetype.
		/// </summary>
		/// <returns>Any type as the BaseType</returns>
		public BaseType AnyType
		{
			get
			{
				switch (tag)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					case 6: return Item7;
					default: throw new System.NotSupportedException("Unrecognized tag value: " + tag);
				}
			}
		}
	}
	/// <summary>
	/// A Discriminated union for 8 types.
	/// </summary>
	/// <typeparam name="Type1">Type1</typeparam>
	/// <typeparam name="Type2">Type2</typeparam>
	/// <typeparam name="Type3">Type3</typeparam>
	/// <typeparam name="Type4">Type4</typeparam>
	/// <typeparam name="Type5">Type5</typeparam>
	/// <typeparam name="Type6">Type6</typeparam>
	/// <typeparam name="Type7">Type7</typeparam>
	/// <typeparam name="Type8">Type8</typeparam>
    /// <typeparam name="BaseType"></typeparam>
	[Serializable]
	public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 
		where Type5 : BaseType 
		where Type6 : BaseType 
		where Type7 : BaseType 
		where Type8 : BaseType 
	{
		/// <summary>
		/// Private constructor to support serialization.
		/// </summary>
		private DiscriminatedUnionWithBase() : base() { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type5 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type6"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type6 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type7"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type7 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type8"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type8 item) : base(item) { }

		/// <summary>
		/// Gets any type by returning the basetype.
		/// </summary>
		/// <returns>Any type as the BaseType</returns>
		public BaseType AnyType
		{
			get
			{
				switch (tag)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					case 6: return Item7;
					case 7: return Item8;
					default: throw new System.NotSupportedException("Unrecognized tag value: " + tag);
				}
			}
		}
	}
	/// <summary>
	/// A Discriminated union for 9 types.
	/// </summary>
	/// <typeparam name="Type1">Type1</typeparam>
	/// <typeparam name="Type2">Type2</typeparam>
	/// <typeparam name="Type3">Type3</typeparam>
	/// <typeparam name="Type4">Type4</typeparam>
	/// <typeparam name="Type5">Type5</typeparam>
	/// <typeparam name="Type6">Type6</typeparam>
	/// <typeparam name="Type7">Type7</typeparam>
	/// <typeparam name="Type8">Type8</typeparam>
	/// <typeparam name="Type9">Type9</typeparam>
    /// <typeparam name="BaseType"></typeparam>
	[Serializable]
	public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 
		where Type5 : BaseType 
		where Type6 : BaseType 
		where Type7 : BaseType 
		where Type8 : BaseType 
		where Type9 : BaseType 
	{
		/// <summary>
		/// Private constructor to support serialization.
		/// </summary>
		private DiscriminatedUnionWithBase() : base() { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type5 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type6"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type6 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type7"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type7 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type8"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type8 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type9"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type9 item) : base(item) { }

		/// <summary>
		/// Gets any type by returning the basetype.
		/// </summary>
		/// <returns>Any type as the BaseType</returns>
		public BaseType AnyType
		{
			get
			{
				switch (tag)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					case 6: return Item7;
					case 7: return Item8;
					case 8: return Item9;
					default: throw new System.NotSupportedException("Unrecognized tag value: " + tag);
				}
			}
		}
	}
	/// <summary>
	/// A Discriminated union for 10 types.
	/// </summary>
	/// <typeparam name="Type1">Type1</typeparam>
	/// <typeparam name="Type2">Type2</typeparam>
	/// <typeparam name="Type3">Type3</typeparam>
	/// <typeparam name="Type4">Type4</typeparam>
	/// <typeparam name="Type5">Type5</typeparam>
	/// <typeparam name="Type6">Type6</typeparam>
	/// <typeparam name="Type7">Type7</typeparam>
	/// <typeparam name="Type8">Type8</typeparam>
	/// <typeparam name="Type9">Type9</typeparam>
	/// <typeparam name="Type10">Type10</typeparam>
    /// <typeparam name="BaseType"></typeparam>
	[Serializable]
	public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>
		where Type1 : BaseType 
		where Type2 : BaseType 
		where Type3 : BaseType 
		where Type4 : BaseType 
		where Type5 : BaseType 
		where Type6 : BaseType 
		where Type7 : BaseType 
		where Type8 : BaseType 
		where Type9 : BaseType 
		where Type10 : BaseType 
	{
		/// <summary>
		/// Private constructor to support serialization.
		/// </summary>
		private DiscriminatedUnionWithBase() : base() { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type5 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type6"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type6 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type7"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type7 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type8"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type8 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type9"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type9 item) : base(item) { }
		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type10"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnionWithBase(Type10 item) : base(item) { }

		/// <summary>
		/// Gets any type by returning the basetype.
		/// </summary>
		/// <returns>Any type as the BaseType</returns>
		public BaseType AnyType
		{
			get
			{
				switch (tag)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					case 6: return Item7;
					case 7: return Item8;
					case 8: return Item9;
					case 9: return Item10;
					default: throw new System.NotSupportedException("Unrecognized tag value: " + tag);
				}
			}
		}
	}
}


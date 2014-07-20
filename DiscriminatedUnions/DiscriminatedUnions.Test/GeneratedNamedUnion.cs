
namespace TypescriptGeneration.Model
{
	using System;
	using DiscriminatedUnions;
	using System.Collections.Generic;
	using DiscriminatedUnions.Test.TestModelClasses;

	[Serializable]
	public class TestNamedUnionGeneration : DiscriminatedUnion<Person,Teacher>
	{
		/// <summary>
		/// Creates a new TestNamedUnionGeneration representing a Person.
		/// </summary>
		/// <param name="person"></param>
		public TestNamedUnionGeneration(Person person) : base(person) { }
		/// <summary>
		/// Creates a new TestNamedUnionGeneration representing a Teacher.
		/// </summary>
		/// <param name="teacher"></param>
		public TestNamedUnionGeneration(Teacher teacher) : base(teacher) { }
	}


    /// <summary>
    /// Represents a list of generic type arguments. 
    /// </summary>
    [Serializable]
    public class TestNamedUnionGenerationList : List<TestNamedUnionGeneration>
    {
	        /// <summary>
        /// Creates and adds a new TestNamedUnionGeneration using the given Person.
        /// </summary>
        /// <param name="primitive">The primitive to add.</param>
        public void Add(Person person)
        {
            Add(new TestNamedUnionGeneration(person));
        }
		        /// <summary>
        /// Creates and adds a new TestNamedUnionGeneration using the given Teacher.
        /// </summary>
        /// <param name="primitive">The primitive to add.</param>
        public void Add(Teacher teacher)
        {
            Add(new TestNamedUnionGeneration(teacher));
        }
		    }


	public static class TestNamedUnionGenerationExtensions
	{
		/// <summary>
		/// Turns the Person into a TestNamedUnionGeneration.
		/// </summary>
		/// <param name="person"></param>
		public static TestNamedUnionGeneration ToTestNamedUnionGeneration(this Person person)
		{
			return new TestNamedUnionGeneration(person);
		}
		/// <summary>
		/// Turns the Teacher into a TestNamedUnionGeneration.
		/// </summary>
		/// <param name="teacher"></param>
		public static TestNamedUnionGeneration ToTestNamedUnionGeneration(this Teacher teacher)
		{
			return new TestNamedUnionGeneration(teacher);
		}
	}
}



namespace DiscriminatedUnions.Test
{
	using System;
	using System.Collections.Generic;using DiscriminatedUnions.Test.TestModelClasses;

	[Serializable]
	public class GeneratedNamedUnion : DiscriminatedUnion<Teacher,Student>
	{
		/// <summary>
		/// Creates a new GeneratedNamedUnion representing a Teacher.
		/// </summary>
		/// <param name="teacher"></param>
		public GeneratedNamedUnion(Teacher teacher) : base(teacher) { }
		/// <summary>
		/// Creates a new GeneratedNamedUnion representing a Student.
		/// </summary>
		/// <param name="student"></param>
		public GeneratedNamedUnion(Student student) : base(student) { }
	}


    /// <summary>
    /// Represents a list of generic type arguments. 
    /// </summary>
    [Serializable]
    public class TypescriptGenericTypeArguments : List<GeneratedNamedUnion>
    {
	        /// <summary>
        /// Creates and adds a new GeneratedNamedUnion using the given Teacher.
        /// </summary>
        /// <param name="primitive">The primitive to add.</param>
        public void Add(Teacher teacher)
        {
            Add(new GeneratedNamedUnion(teacher));
        }
		        /// <summary>
        /// Creates and adds a new GeneratedNamedUnion using the given Student.
        /// </summary>
        /// <param name="primitive">The primitive to add.</param>
        public void Add(Student student)
        {
            Add(new GeneratedNamedUnion(student));
        }
		    }


	public static class GeneratedNamedUnionExtensions
	{
		/// <summary>
		/// Turns the Teacher into a GeneratedNamedUnion.
		/// </summary>
		/// <param name="teacher"></param>
		public static GeneratedNamedUnion ToGeneratedNamedUnion(this Teacher teacher)
		{
			return new GeneratedNamedUnion(teacher);
		}
		/// <summary>
		/// Turns the Student into a GeneratedNamedUnion.
		/// </summary>
		/// <param name="student"></param>
		public static GeneratedNamedUnion ToGeneratedNamedUnion(this Student student)
		{
			return new GeneratedNamedUnion(student);
		}
	}
}


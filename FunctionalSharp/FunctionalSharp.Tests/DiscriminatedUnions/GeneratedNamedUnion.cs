







namespace FunctionalSharp.DiscriminatedUnions.Test
{
	using System;
	using System.Linq;
	using DiscriminatedUnions;
	using System.Collections.Generic;
	using DiscriminatedUnions.Test.TestModelClasses;

    /// <summary>
    /// Represents a discriminated union of the following types:Student,Teacher. 
    /// </summary>
	[Serializable]
	public class GeneratedUnion : DiscriminatedUnion<Student,Teacher>
	{
		/// <summary>
		/// Creates a new GeneratedUnion representing a Student.
		/// </summary>
		/// <param name="student"></param>
		public GeneratedUnion(Student student) : base(student) { }
		/// <summary>
		/// Creates a new GeneratedUnion representing a Teacher.
		/// </summary>
		/// <param name="teacher"></param>
		public GeneratedUnion(Teacher teacher) : base(teacher) { }
	}


    /// <summary>
    /// Represents a list of GeneratedUnion. 
    /// </summary>
    [Serializable]
    public class GeneratedUnionList : List<GeneratedUnion>
    {
		/// <summary>
		/// creates a new GeneratedUnionList without contents.
		/// </summary>
		public GeneratedUnionList() : base() { }

		/// <summary>
		/// creates a new GeneratedUnionList with the starting values as its contents.
		/// <param name="values">startingValues</param>
		/// </summary>
		public GeneratedUnionList(IEnumerable<GeneratedUnion> values) : base(values) { }

		/// <summary>
		/// creates a new GeneratedUnionList with the starting values as its contents.
		/// <param name="student">startingValues</param>
		/// </summary>
		public GeneratedUnionList(IEnumerable<Student> student) : base(student.Select(x => x.ToGeneratedUnion())) { }

        /// <summary>
        /// Creates and adds a new GeneratedUnion using the given Student.
        /// </summary>
        /// <param name="student">The student to add.</param>
        public void Add(Student student)
        {
            Add(new GeneratedUnion(student));
        }

		/// <summary>
		/// creates a new GeneratedUnionList with the starting values as its contents.
		/// <param name="teacher">startingValues</param>
		/// </summary>
		public GeneratedUnionList(IEnumerable<Teacher> teacher) : base(teacher.Select(x => x.ToGeneratedUnion())) { }

        /// <summary>
        /// Creates and adds a new GeneratedUnion using the given Teacher.
        /// </summary>
        /// <param name="teacher">The teacher to add.</param>
        public void Add(Teacher teacher)
        {
            Add(new GeneratedUnion(teacher));
        }

    }

    /// <summary>
    /// provides extensionmethods for GeneratedUnion. 
    /// </summary>
	public static class GeneratedUnionExtensions
	{
		/// <summary>
		/// Turns the Student into a GeneratedUnion.
		/// </summary>
		/// <param name="student"></param>
		public static GeneratedUnion ToGeneratedUnion(this Student student)
		{
			return new GeneratedUnion(student);
		}
		/// <summary>
		/// Turns the Teacher into a GeneratedUnion.
		/// </summary>
		/// <param name="teacher"></param>
		public static GeneratedUnion ToGeneratedUnion(this Teacher teacher)
		{
			return new GeneratedUnion(teacher);
		}


        public static void Match(this IEnumerable<GeneratedUnion> values, Action<Student> actionForStudent,Action<Teacher> actionForTeacher)
        {
            values.Match<GeneratedUnion, Student,Teacher>(actionForStudent,actionForTeacher);
        }

        public static IEnumerable<TreturnType> Match<TreturnType>(this IEnumerable<GeneratedUnion> values, Func<Student, TreturnType> functionForStudent,Func<Teacher, TreturnType> functionForTeacher)
        {
            return values.Match<GeneratedUnion, Student,Teacher, TreturnType>(functionForStudent,functionForTeacher);
        }
	}
}


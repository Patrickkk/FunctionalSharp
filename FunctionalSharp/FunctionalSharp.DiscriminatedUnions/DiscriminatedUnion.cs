






namespace FunctionalSharp.DiscriminatedUnions
{
	using System;
	using System.ComponentModel;
	/// <summary>
	/// A Discriminated union for 2 types.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
	[Serializable]
	public class DiscriminatedUnion<Type1, Type2>
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
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
		
		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
		
		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;


		/// <summary>
		/// Transforms the union into a new type using the given functions for the transformation.
		/// </summary>
		/// <typeparam name="ReturnType"></typeparam>
		/// <param name="Function1">Function to run for <typeparamref name="Type1"/></param>
		/// <param name="Function2">Function to run for <typeparamref name="Type2"/></param>
		/// <returns></returns>
		public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2)
		{
			switch (tag)
			{
				case 0: return Function1(Item1);
				case 1: return Function2(Item2);

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="Action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="Action2">Action to run for <typeparamref name="Type2"/></param>
		public void Match(Action<Type1> Action1, Action<Type2> Action2)
		{
			switch (tag)
			{
				case 0: Action1(Item1); break;
				case 1: Action2(Item2); break;

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}
	}	/// <summary>
	/// A Discriminated union for 3 types.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
	[Serializable]
	public class DiscriminatedUnion<Type1, Type2, Type3>
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
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
		
		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
		
		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
		
		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;


		/// <summary>
		/// Transforms the union into a new type using the given functions for the transformation.
		/// </summary>
		/// <typeparam name="ReturnType"></typeparam>
		/// <param name="Function1">Function to run for <typeparamref name="Type1"/></param>
		/// <param name="Function2">Function to run for <typeparamref name="Type2"/></param>
		/// <param name="Function3">Function to run for <typeparamref name="Type3"/></param>
		/// <returns></returns>
		public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3)
		{
			switch (tag)
			{
				case 0: return Function1(Item1);
				case 1: return Function2(Item2);
				case 2: return Function3(Item3);

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="Action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="Action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="Action3">Action to run for <typeparamref name="Type3"/></param>
		public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3)
		{
			switch (tag)
			{
				case 0: Action1(Item1); break;
				case 1: Action2(Item2); break;
				case 2: Action3(Item3); break;

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}
	}	/// <summary>
	/// A Discriminated union for 4 types.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
	[Serializable]
	public class DiscriminatedUnion<Type1, Type2, Type3, Type4>
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
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
		
		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
		
		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
		
		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
		
		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;


		/// <summary>
		/// Transforms the union into a new type using the given functions for the transformation.
		/// </summary>
		/// <typeparam name="ReturnType"></typeparam>
		/// <param name="Function1">Function to run for <typeparamref name="Type1"/></param>
		/// <param name="Function2">Function to run for <typeparamref name="Type2"/></param>
		/// <param name="Function3">Function to run for <typeparamref name="Type3"/></param>
		/// <param name="Function4">Function to run for <typeparamref name="Type4"/></param>
		/// <returns></returns>
		public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4)
		{
			switch (tag)
			{
				case 0: return Function1(Item1);
				case 1: return Function2(Item2);
				case 2: return Function3(Item3);
				case 3: return Function4(Item4);

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="Action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="Action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="Action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="Action4">Action to run for <typeparamref name="Type4"/></param>
		public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4)
		{
			switch (tag)
			{
				case 0: Action1(Item1); break;
				case 1: Action2(Item2); break;
				case 2: Action3(Item3); break;
				case 3: Action4(Item4); break;

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}
	}	/// <summary>
	/// A Discriminated union for 5 types.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
	[Serializable]
	public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>
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
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
		
		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
		
		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
		
		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
		
		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
		
		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;


		/// <summary>
		/// Transforms the union into a new type using the given functions for the transformation.
		/// </summary>
		/// <typeparam name="ReturnType"></typeparam>
		/// <param name="Function1">Function to run for <typeparamref name="Type1"/></param>
		/// <param name="Function2">Function to run for <typeparamref name="Type2"/></param>
		/// <param name="Function3">Function to run for <typeparamref name="Type3"/></param>
		/// <param name="Function4">Function to run for <typeparamref name="Type4"/></param>
		/// <param name="Function5">Function to run for <typeparamref name="Type5"/></param>
		/// <returns></returns>
		public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5)
		{
			switch (tag)
			{
				case 0: return Function1(Item1);
				case 1: return Function2(Item2);
				case 2: return Function3(Item3);
				case 3: return Function4(Item4);
				case 4: return Function5(Item5);

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="Action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="Action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="Action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="Action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="Action5">Action to run for <typeparamref name="Type5"/></param>
		public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5)
		{
			switch (tag)
			{
				case 0: Action1(Item1); break;
				case 1: Action2(Item2); break;
				case 2: Action3(Item3); break;
				case 3: Action4(Item4); break;
				case 4: Action5(Item5); break;

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}
	}	/// <summary>
	/// A Discriminated union for 6 types.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
	[Serializable]
	public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>
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
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
		
		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
		
		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
		
		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
		
		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
		
		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type6"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }
		
		/// <summary>
		/// The storage for type6.
		/// </summary>
		protected readonly Type6 Item6;


		/// <summary>
		/// Transforms the union into a new type using the given functions for the transformation.
		/// </summary>
		/// <typeparam name="ReturnType"></typeparam>
		/// <param name="Function1">Function to run for <typeparamref name="Type1"/></param>
		/// <param name="Function2">Function to run for <typeparamref name="Type2"/></param>
		/// <param name="Function3">Function to run for <typeparamref name="Type3"/></param>
		/// <param name="Function4">Function to run for <typeparamref name="Type4"/></param>
		/// <param name="Function5">Function to run for <typeparamref name="Type5"/></param>
		/// <param name="Function6">Function to run for <typeparamref name="Type6"/></param>
		/// <returns></returns>
		public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6)
		{
			switch (tag)
			{
				case 0: return Function1(Item1);
				case 1: return Function2(Item2);
				case 2: return Function3(Item3);
				case 3: return Function4(Item4);
				case 4: return Function5(Item5);
				case 5: return Function6(Item6);

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="Action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="Action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="Action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="Action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="Action5">Action to run for <typeparamref name="Type5"/></param>
		/// <param name="Action6">Action to run for <typeparamref name="Type6"/></param>
		public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6)
		{
			switch (tag)
			{
				case 0: Action1(Item1); break;
				case 1: Action2(Item2); break;
				case 2: Action3(Item3); break;
				case 3: Action4(Item4); break;
				case 4: Action5(Item5); break;
				case 5: Action6(Item6); break;

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}
	}	/// <summary>
	/// A Discriminated union for 7 types.
	/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
	[Serializable]
	public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>
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
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
		
		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
		
		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
		
		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
		
		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
		
		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type6"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }
		
		/// <summary>
		/// The storage for type6.
		/// </summary>
		protected readonly Type6 Item6;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type7"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }
		
		/// <summary>
		/// The storage for type7.
		/// </summary>
		protected readonly Type7 Item7;


		/// <summary>
		/// Transforms the union into a new type using the given functions for the transformation.
		/// </summary>
		/// <typeparam name="ReturnType"></typeparam>
		/// <param name="Function1">Function to run for <typeparamref name="Type1"/></param>
		/// <param name="Function2">Function to run for <typeparamref name="Type2"/></param>
		/// <param name="Function3">Function to run for <typeparamref name="Type3"/></param>
		/// <param name="Function4">Function to run for <typeparamref name="Type4"/></param>
		/// <param name="Function5">Function to run for <typeparamref name="Type5"/></param>
		/// <param name="Function6">Function to run for <typeparamref name="Type6"/></param>
		/// <param name="Function7">Function to run for <typeparamref name="Type7"/></param>
		/// <returns></returns>
		public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7)
		{
			switch (tag)
			{
				case 0: return Function1(Item1);
				case 1: return Function2(Item2);
				case 2: return Function3(Item3);
				case 3: return Function4(Item4);
				case 4: return Function5(Item5);
				case 5: return Function6(Item6);
				case 6: return Function7(Item7);

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="Action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="Action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="Action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="Action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="Action5">Action to run for <typeparamref name="Type5"/></param>
		/// <param name="Action6">Action to run for <typeparamref name="Type6"/></param>
		/// <param name="Action7">Action to run for <typeparamref name="Type7"/></param>
		public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7)
		{
			switch (tag)
			{
				case 0: Action1(Item1); break;
				case 1: Action2(Item2); break;
				case 2: Action3(Item3); break;
				case 3: Action4(Item4); break;
				case 4: Action5(Item5); break;
				case 5: Action6(Item6); break;
				case 6: Action7(Item7); break;

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}
	}	/// <summary>
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
	[Serializable]
	public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>
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
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
		
		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
		
		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
		
		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
		
		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
		
		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type6"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }
		
		/// <summary>
		/// The storage for type6.
		/// </summary>
		protected readonly Type6 Item6;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type7"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }
		
		/// <summary>
		/// The storage for type7.
		/// </summary>
		protected readonly Type7 Item7;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type8"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type8 item) { Item8 = item; tag = 7; }
		
		/// <summary>
		/// The storage for type8.
		/// </summary>
		protected readonly Type8 Item8;


		/// <summary>
		/// Transforms the union into a new type using the given functions for the transformation.
		/// </summary>
		/// <typeparam name="ReturnType"></typeparam>
		/// <param name="Function1">Function to run for <typeparamref name="Type1"/></param>
		/// <param name="Function2">Function to run for <typeparamref name="Type2"/></param>
		/// <param name="Function3">Function to run for <typeparamref name="Type3"/></param>
		/// <param name="Function4">Function to run for <typeparamref name="Type4"/></param>
		/// <param name="Function5">Function to run for <typeparamref name="Type5"/></param>
		/// <param name="Function6">Function to run for <typeparamref name="Type6"/></param>
		/// <param name="Function7">Function to run for <typeparamref name="Type7"/></param>
		/// <param name="Function8">Function to run for <typeparamref name="Type8"/></param>
		/// <returns></returns>
		public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8)
		{
			switch (tag)
			{
				case 0: return Function1(Item1);
				case 1: return Function2(Item2);
				case 2: return Function3(Item3);
				case 3: return Function4(Item4);
				case 4: return Function5(Item5);
				case 5: return Function6(Item6);
				case 6: return Function7(Item7);
				case 7: return Function8(Item8);

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="Action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="Action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="Action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="Action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="Action5">Action to run for <typeparamref name="Type5"/></param>
		/// <param name="Action6">Action to run for <typeparamref name="Type6"/></param>
		/// <param name="Action7">Action to run for <typeparamref name="Type7"/></param>
		/// <param name="Action8">Action to run for <typeparamref name="Type8"/></param>
		public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8)
		{
			switch (tag)
			{
				case 0: Action1(Item1); break;
				case 1: Action2(Item2); break;
				case 2: Action3(Item3); break;
				case 3: Action4(Item4); break;
				case 4: Action5(Item5); break;
				case 5: Action6(Item6); break;
				case 6: Action7(Item7); break;
				case 7: Action8(Item8); break;

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}
	}	/// <summary>
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
	[Serializable]
	public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>
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
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
		
		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
		
		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
		
		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
		
		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
		
		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type6"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }
		
		/// <summary>
		/// The storage for type6.
		/// </summary>
		protected readonly Type6 Item6;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type7"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }
		
		/// <summary>
		/// The storage for type7.
		/// </summary>
		protected readonly Type7 Item7;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type8"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type8 item) { Item8 = item; tag = 7; }
		
		/// <summary>
		/// The storage for type8.
		/// </summary>
		protected readonly Type8 Item8;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type9"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type9 item) { Item9 = item; tag = 8; }
		
		/// <summary>
		/// The storage for type9.
		/// </summary>
		protected readonly Type9 Item9;


		/// <summary>
		/// Transforms the union into a new type using the given functions for the transformation.
		/// </summary>
		/// <typeparam name="ReturnType"></typeparam>
		/// <param name="Function1">Function to run for <typeparamref name="Type1"/></param>
		/// <param name="Function2">Function to run for <typeparamref name="Type2"/></param>
		/// <param name="Function3">Function to run for <typeparamref name="Type3"/></param>
		/// <param name="Function4">Function to run for <typeparamref name="Type4"/></param>
		/// <param name="Function5">Function to run for <typeparamref name="Type5"/></param>
		/// <param name="Function6">Function to run for <typeparamref name="Type6"/></param>
		/// <param name="Function7">Function to run for <typeparamref name="Type7"/></param>
		/// <param name="Function8">Function to run for <typeparamref name="Type8"/></param>
		/// <param name="Function9">Function to run for <typeparamref name="Type9"/></param>
		/// <returns></returns>
		public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8, Func<Type9, ReturnType> Function9)
		{
			switch (tag)
			{
				case 0: return Function1(Item1);
				case 1: return Function2(Item2);
				case 2: return Function3(Item3);
				case 3: return Function4(Item4);
				case 4: return Function5(Item5);
				case 5: return Function6(Item6);
				case 6: return Function7(Item7);
				case 7: return Function8(Item8);
				case 8: return Function9(Item9);

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="Action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="Action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="Action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="Action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="Action5">Action to run for <typeparamref name="Type5"/></param>
		/// <param name="Action6">Action to run for <typeparamref name="Type6"/></param>
		/// <param name="Action7">Action to run for <typeparamref name="Type7"/></param>
		/// <param name="Action8">Action to run for <typeparamref name="Type8"/></param>
		/// <param name="Action9">Action to run for <typeparamref name="Type9"/></param>
		public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8, Action<Type9> Action9)
		{
			switch (tag)
			{
				case 0: Action1(Item1); break;
				case 1: Action2(Item2); break;
				case 2: Action3(Item3); break;
				case 3: Action4(Item4); break;
				case 4: Action5(Item5); break;
				case 5: Action6(Item6); break;
				case 6: Action7(Item7); break;
				case 7: Action8(Item8); break;
				case 8: Action9(Item9); break;

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}
	}	/// <summary>
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
	[Serializable]
	public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>
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
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
		
		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type2"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
		
		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type3"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
		
		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type4"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
		
		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type5"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
		
		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type6"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }
		
		/// <summary>
		/// The storage for type6.
		/// </summary>
		protected readonly Type6 Item6;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type7"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }
		
		/// <summary>
		/// The storage for type7.
		/// </summary>
		protected readonly Type7 Item7;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type8"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type8 item) { Item8 = item; tag = 7; }
		
		/// <summary>
		/// The storage for type8.
		/// </summary>
		protected readonly Type8 Item8;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type9"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type9 item) { Item9 = item; tag = 8; }
		
		/// <summary>
		/// The storage for type9.
		/// </summary>
		protected readonly Type9 Item9;

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type10"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type10 item) { Item10 = item; tag = 9; }
		
		/// <summary>
		/// The storage for type10.
		/// </summary>
		protected readonly Type10 Item10;


		/// <summary>
		/// Transforms the union into a new type using the given functions for the transformation.
		/// </summary>
		/// <typeparam name="ReturnType"></typeparam>
		/// <param name="Function1">Function to run for <typeparamref name="Type1"/></param>
		/// <param name="Function2">Function to run for <typeparamref name="Type2"/></param>
		/// <param name="Function3">Function to run for <typeparamref name="Type3"/></param>
		/// <param name="Function4">Function to run for <typeparamref name="Type4"/></param>
		/// <param name="Function5">Function to run for <typeparamref name="Type5"/></param>
		/// <param name="Function6">Function to run for <typeparamref name="Type6"/></param>
		/// <param name="Function7">Function to run for <typeparamref name="Type7"/></param>
		/// <param name="Function8">Function to run for <typeparamref name="Type8"/></param>
		/// <param name="Function9">Function to run for <typeparamref name="Type9"/></param>
		/// <param name="Function10">Function to run for <typeparamref name="Type10"/></param>
		/// <returns></returns>
		public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8, Func<Type9, ReturnType> Function9, Func<Type10, ReturnType> Function10)
		{
			switch (tag)
			{
				case 0: return Function1(Item1);
				case 1: return Function2(Item2);
				case 2: return Function3(Item3);
				case 3: return Function4(Item4);
				case 4: return Function5(Item5);
				case 5: return Function6(Item6);
				case 6: return Function7(Item7);
				case 7: return Function8(Item8);
				case 8: return Function9(Item9);
				case 9: return Function10(Item10);

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="Action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="Action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="Action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="Action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="Action5">Action to run for <typeparamref name="Type5"/></param>
		/// <param name="Action6">Action to run for <typeparamref name="Type6"/></param>
		/// <param name="Action7">Action to run for <typeparamref name="Type7"/></param>
		/// <param name="Action8">Action to run for <typeparamref name="Type8"/></param>
		/// <param name="Action9">Action to run for <typeparamref name="Type9"/></param>
		/// <param name="Action10">Action to run for <typeparamref name="Type10"/></param>
		public void Match(Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8, Action<Type9> Action9, Action<Type10> Action10)
		{
			switch (tag)
			{
				case 0: Action1(Item1); break;
				case 1: Action2(Item2); break;
				case 2: Action3(Item3); break;
				case 3: Action4(Item4); break;
				case 4: Action5(Item5); break;
				case 5: Action6(Item6); break;
				case 6: Action7(Item7); break;
				case 7: Action8(Item8); break;
				case 8: Action9(Item9); break;
				case 9: Action10(Item10); break;

				default: throw new InvalidEnumArgumentException("Unrecognized tag value: " + tag);
			}
		}
	}
}


namespace FunctionalSharp.DiscriminatedUnions
{
	using System;
	/// <summary>
	/// A Discriminated union for <<NumberOfTypes>> types.
	/// </summary>
    /// <typeparam name="Type1">Type0</typeparam>
    /// <typeparam name="Type2">Type1</typeparam>
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
		/// Runs Actions for the matched types.
		/// </summary>
		public DiscriminatedUnion(object value)
		{
			if(value.GetType() == typeof(Type1))
			{
                Item1 = (Type1)value;
				tag = 0;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else
			{
				throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }

		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

        /// <summary>
        /// Conversion from Type1 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2>(Type1 value)
        {
            return new DiscriminatedUnion<Type1, Type2>(value);
        }

        /// <summary>
        /// Conversion from Type2 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2>(Type2 value)
        {
            return new DiscriminatedUnion<Type1, Type2>(value);
        }

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="action2">Action to run for <typeparamref name="Type2"/></param>
        public void Match(Action<Type1> action1, Action<Type2> action2)
		{
			if(action1 == null)
			{
				throw new ArgumentNullException("The argument action1 is null");
			}
			if(action2 == null)
			{
				throw new ArgumentNullException("The argument action2 is null");
			}

            switch (tag)
			{
				case 0: action1(Item1); break;
				case 1: action2(Item2); break;
                default: throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}
	}
	/// <summary>
	/// A Discriminated union for <<NumberOfTypes>> types.
	/// </summary>
    /// <typeparam name="Type1">Type0</typeparam>
    /// <typeparam name="Type2">Type1</typeparam>
    /// <typeparam name="Type3">Type2</typeparam>
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
		/// Runs Actions for the matched types.
		/// </summary>
		public DiscriminatedUnion(object value)
		{
			if(value.GetType() == typeof(Type1))
			{
                Item1 = (Type1)value;
				tag = 0;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else
			{
				throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }

		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

        /// <summary>
        /// Conversion from Type1 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3>(Type1 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3>(value);
        }

        /// <summary>
        /// Conversion from Type2 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3>(Type2 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3>(value);
        }

        /// <summary>
        /// Conversion from Type3 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3>(Type3 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3>(value);
        }

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="action3">Action to run for <typeparamref name="Type3"/></param>
        public void Match(Action<Type1> action1, Action<Type2> action2, Action<Type3> action3)
		{
			if(action1 == null)
			{
				throw new ArgumentNullException("The argument action1 is null");
			}
			if(action2 == null)
			{
				throw new ArgumentNullException("The argument action2 is null");
			}
			if(action3 == null)
			{
				throw new ArgumentNullException("The argument action3 is null");
			}

            switch (tag)
			{
				case 0: action1(Item1); break;
				case 1: action2(Item2); break;
				case 2: action3(Item3); break;
                default: throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}
	}
	/// <summary>
	/// A Discriminated union for <<NumberOfTypes>> types.
	/// </summary>
    /// <typeparam name="Type1">Type0</typeparam>
    /// <typeparam name="Type2">Type1</typeparam>
    /// <typeparam name="Type3">Type2</typeparam>
    /// <typeparam name="Type4">Type3</typeparam>
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
		/// Runs Actions for the matched types.
		/// </summary>
		public DiscriminatedUnion(object value)
		{
			if(value.GetType() == typeof(Type1))
			{
                Item1 = (Type1)value;
				tag = 0;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else
			{
				throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }

		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

        /// <summary>
        /// Conversion from Type1 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4>(Type1 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4>(value);
        }

        /// <summary>
        /// Conversion from Type2 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4>(Type2 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4>(value);
        }

        /// <summary>
        /// Conversion from Type3 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4>(Type3 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4>(value);
        }

        /// <summary>
        /// Conversion from Type4 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4>(Type4 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4>(value);
        }

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="action4">Action to run for <typeparamref name="Type4"/></param>
        public void Match(Action<Type1> action1, Action<Type2> action2, Action<Type3> action3, Action<Type4> action4)
		{
			if(action1 == null)
			{
				throw new ArgumentNullException("The argument action1 is null");
			}
			if(action2 == null)
			{
				throw new ArgumentNullException("The argument action2 is null");
			}
			if(action3 == null)
			{
				throw new ArgumentNullException("The argument action3 is null");
			}
			if(action4 == null)
			{
				throw new ArgumentNullException("The argument action4 is null");
			}

            switch (tag)
			{
				case 0: action1(Item1); break;
				case 1: action2(Item2); break;
				case 2: action3(Item3); break;
				case 3: action4(Item4); break;
                default: throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}
	}
	/// <summary>
	/// A Discriminated union for <<NumberOfTypes>> types.
	/// </summary>
    /// <typeparam name="Type1">Type0</typeparam>
    /// <typeparam name="Type2">Type1</typeparam>
    /// <typeparam name="Type3">Type2</typeparam>
    /// <typeparam name="Type4">Type3</typeparam>
    /// <typeparam name="Type5">Type4</typeparam>
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
		/// Runs Actions for the matched types.
		/// </summary>
		public DiscriminatedUnion(object value)
		{
			if(value.GetType() == typeof(Type1))
			{
                Item1 = (Type1)value;
				tag = 0;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else
			{
				throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }

		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

        /// <summary>
        /// Conversion from Type1 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(Type1 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(value);
        }

        /// <summary>
        /// Conversion from Type2 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(Type2 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(value);
        }

        /// <summary>
        /// Conversion from Type3 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(Type3 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(value);
        }

        /// <summary>
        /// Conversion from Type4 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(Type4 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(value);
        }

        /// <summary>
        /// Conversion from Type5 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(Type5 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(value);
        }

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="action5">Action to run for <typeparamref name="Type5"/></param>
        public void Match(Action<Type1> action1, Action<Type2> action2, Action<Type3> action3, Action<Type4> action4, Action<Type5> action5)
		{
			if(action1 == null)
			{
				throw new ArgumentNullException("The argument action1 is null");
			}
			if(action2 == null)
			{
				throw new ArgumentNullException("The argument action2 is null");
			}
			if(action3 == null)
			{
				throw new ArgumentNullException("The argument action3 is null");
			}
			if(action4 == null)
			{
				throw new ArgumentNullException("The argument action4 is null");
			}
			if(action5 == null)
			{
				throw new ArgumentNullException("The argument action5 is null");
			}

            switch (tag)
			{
				case 0: action1(Item1); break;
				case 1: action2(Item2); break;
				case 2: action3(Item3); break;
				case 3: action4(Item4); break;
				case 4: action5(Item5); break;
                default: throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}
	}
	/// <summary>
	/// A Discriminated union for <<NumberOfTypes>> types.
	/// </summary>
    /// <typeparam name="Type1">Type0</typeparam>
    /// <typeparam name="Type2">Type1</typeparam>
    /// <typeparam name="Type3">Type2</typeparam>
    /// <typeparam name="Type4">Type3</typeparam>
    /// <typeparam name="Type5">Type4</typeparam>
    /// <typeparam name="Type6">Type5</typeparam>
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
		/// Runs Actions for the matched types.
		/// </summary>
		public DiscriminatedUnion(object value)
		{
			if(value.GetType() == typeof(Type1))
			{
                Item1 = (Type1)value;
				tag = 0;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else
			{
				throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }

		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

		/// <summary>
		/// The storage for type6.
		/// </summary>
		protected readonly Type6 Item6;

        /// <summary>
        /// Conversion from Type1 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(Type1 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(value);
        }

        /// <summary>
        /// Conversion from Type2 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(Type2 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(value);
        }

        /// <summary>
        /// Conversion from Type3 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(Type3 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(value);
        }

        /// <summary>
        /// Conversion from Type4 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(Type4 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(value);
        }

        /// <summary>
        /// Conversion from Type5 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(Type5 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(value);
        }

        /// <summary>
        /// Conversion from Type6 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(Type6 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(value);
        }

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="action5">Action to run for <typeparamref name="Type5"/></param>
		/// <param name="action6">Action to run for <typeparamref name="Type6"/></param>
        public void Match(Action<Type1> action1, Action<Type2> action2, Action<Type3> action3, Action<Type4> action4, Action<Type5> action5, Action<Type6> action6)
		{
			if(action1 == null)
			{
				throw new ArgumentNullException("The argument action1 is null");
			}
			if(action2 == null)
			{
				throw new ArgumentNullException("The argument action2 is null");
			}
			if(action3 == null)
			{
				throw new ArgumentNullException("The argument action3 is null");
			}
			if(action4 == null)
			{
				throw new ArgumentNullException("The argument action4 is null");
			}
			if(action5 == null)
			{
				throw new ArgumentNullException("The argument action5 is null");
			}
			if(action6 == null)
			{
				throw new ArgumentNullException("The argument action6 is null");
			}

            switch (tag)
			{
				case 0: action1(Item1); break;
				case 1: action2(Item2); break;
				case 2: action3(Item3); break;
				case 3: action4(Item4); break;
				case 4: action5(Item5); break;
				case 5: action6(Item6); break;
                default: throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}
	}
	/// <summary>
	/// A Discriminated union for <<NumberOfTypes>> types.
	/// </summary>
    /// <typeparam name="Type1">Type0</typeparam>
    /// <typeparam name="Type2">Type1</typeparam>
    /// <typeparam name="Type3">Type2</typeparam>
    /// <typeparam name="Type4">Type3</typeparam>
    /// <typeparam name="Type5">Type4</typeparam>
    /// <typeparam name="Type6">Type5</typeparam>
    /// <typeparam name="Type7">Type6</typeparam>
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
		/// Runs Actions for the matched types.
		/// </summary>
		public DiscriminatedUnion(object value)
		{
			if(value.GetType() == typeof(Type1))
			{
                Item1 = (Type1)value;
				tag = 0;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else
			{
				throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }

		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

		/// <summary>
		/// The storage for type6.
		/// </summary>
		protected readonly Type6 Item6;

		/// <summary>
		/// The storage for type7.
		/// </summary>
		protected readonly Type7 Item7;

        /// <summary>
        /// Conversion from Type1 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(Type1 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(value);
        }

        /// <summary>
        /// Conversion from Type2 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(Type2 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(value);
        }

        /// <summary>
        /// Conversion from Type3 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(Type3 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(value);
        }

        /// <summary>
        /// Conversion from Type4 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(Type4 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(value);
        }

        /// <summary>
        /// Conversion from Type5 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(Type5 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(value);
        }

        /// <summary>
        /// Conversion from Type6 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(Type6 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(value);
        }

        /// <summary>
        /// Conversion from Type7 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(Type7 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(value);
        }

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="action5">Action to run for <typeparamref name="Type5"/></param>
		/// <param name="action6">Action to run for <typeparamref name="Type6"/></param>
		/// <param name="action7">Action to run for <typeparamref name="Type7"/></param>
        public void Match(Action<Type1> action1, Action<Type2> action2, Action<Type3> action3, Action<Type4> action4, Action<Type5> action5, Action<Type6> action6, Action<Type7> action7)
		{
			if(action1 == null)
			{
				throw new ArgumentNullException("The argument action1 is null");
			}
			if(action2 == null)
			{
				throw new ArgumentNullException("The argument action2 is null");
			}
			if(action3 == null)
			{
				throw new ArgumentNullException("The argument action3 is null");
			}
			if(action4 == null)
			{
				throw new ArgumentNullException("The argument action4 is null");
			}
			if(action5 == null)
			{
				throw new ArgumentNullException("The argument action5 is null");
			}
			if(action6 == null)
			{
				throw new ArgumentNullException("The argument action6 is null");
			}
			if(action7 == null)
			{
				throw new ArgumentNullException("The argument action7 is null");
			}

            switch (tag)
			{
				case 0: action1(Item1); break;
				case 1: action2(Item2); break;
				case 2: action3(Item3); break;
				case 3: action4(Item4); break;
				case 4: action5(Item5); break;
				case 5: action6(Item6); break;
				case 6: action7(Item7); break;
                default: throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}
	}
	/// <summary>
	/// A Discriminated union for <<NumberOfTypes>> types.
	/// </summary>
    /// <typeparam name="Type1">Type0</typeparam>
    /// <typeparam name="Type2">Type1</typeparam>
    /// <typeparam name="Type3">Type2</typeparam>
    /// <typeparam name="Type4">Type3</typeparam>
    /// <typeparam name="Type5">Type4</typeparam>
    /// <typeparam name="Type6">Type5</typeparam>
    /// <typeparam name="Type7">Type6</typeparam>
    /// <typeparam name="Type8">Type7</typeparam>
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
		/// Runs Actions for the matched types.
		/// </summary>
		public DiscriminatedUnion(object value)
		{
			if(value.GetType() == typeof(Type1))
			{
                Item1 = (Type1)value;
				tag = 0;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else
			{
				throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type8 item) { Item8 = item; tag = 7; }

		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

		/// <summary>
		/// The storage for type6.
		/// </summary>
		protected readonly Type6 Item6;

		/// <summary>
		/// The storage for type7.
		/// </summary>
		protected readonly Type7 Item7;

		/// <summary>
		/// The storage for type8.
		/// </summary>
		protected readonly Type8 Item8;

        /// <summary>
        /// Conversion from Type1 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(Type1 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(value);
        }

        /// <summary>
        /// Conversion from Type2 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(Type2 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(value);
        }

        /// <summary>
        /// Conversion from Type3 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(Type3 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(value);
        }

        /// <summary>
        /// Conversion from Type4 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(Type4 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(value);
        }

        /// <summary>
        /// Conversion from Type5 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(Type5 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(value);
        }

        /// <summary>
        /// Conversion from Type6 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(Type6 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(value);
        }

        /// <summary>
        /// Conversion from Type7 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(Type7 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(value);
        }

        /// <summary>
        /// Conversion from Type8 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(Type8 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(value);
        }

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="action5">Action to run for <typeparamref name="Type5"/></param>
		/// <param name="action6">Action to run for <typeparamref name="Type6"/></param>
		/// <param name="action7">Action to run for <typeparamref name="Type7"/></param>
		/// <param name="action8">Action to run for <typeparamref name="Type8"/></param>
        public void Match(Action<Type1> action1, Action<Type2> action2, Action<Type3> action3, Action<Type4> action4, Action<Type5> action5, Action<Type6> action6, Action<Type7> action7, Action<Type8> action8)
		{
			if(action1 == null)
			{
				throw new ArgumentNullException("The argument action1 is null");
			}
			if(action2 == null)
			{
				throw new ArgumentNullException("The argument action2 is null");
			}
			if(action3 == null)
			{
				throw new ArgumentNullException("The argument action3 is null");
			}
			if(action4 == null)
			{
				throw new ArgumentNullException("The argument action4 is null");
			}
			if(action5 == null)
			{
				throw new ArgumentNullException("The argument action5 is null");
			}
			if(action6 == null)
			{
				throw new ArgumentNullException("The argument action6 is null");
			}
			if(action7 == null)
			{
				throw new ArgumentNullException("The argument action7 is null");
			}
			if(action8 == null)
			{
				throw new ArgumentNullException("The argument action8 is null");
			}

            switch (tag)
			{
				case 0: action1(Item1); break;
				case 1: action2(Item2); break;
				case 2: action3(Item3); break;
				case 3: action4(Item4); break;
				case 4: action5(Item5); break;
				case 5: action6(Item6); break;
				case 6: action7(Item7); break;
				case 7: action8(Item8); break;
                default: throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}
	}
	/// <summary>
	/// A Discriminated union for <<NumberOfTypes>> types.
	/// </summary>
    /// <typeparam name="Type1">Type0</typeparam>
    /// <typeparam name="Type2">Type1</typeparam>
    /// <typeparam name="Type3">Type2</typeparam>
    /// <typeparam name="Type4">Type3</typeparam>
    /// <typeparam name="Type5">Type4</typeparam>
    /// <typeparam name="Type6">Type5</typeparam>
    /// <typeparam name="Type7">Type6</typeparam>
    /// <typeparam name="Type8">Type7</typeparam>
    /// <typeparam name="Type9">Type8</typeparam>
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
		/// Runs Actions for the matched types.
		/// </summary>
		public DiscriminatedUnion(object value)
		{
			if(value.GetType() == typeof(Type1))
			{
                Item1 = (Type1)value;
				tag = 0;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else
			{
				throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type8 item) { Item8 = item; tag = 7; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type9 item) { Item9 = item; tag = 8; }

		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

		/// <summary>
		/// The storage for type6.
		/// </summary>
		protected readonly Type6 Item6;

		/// <summary>
		/// The storage for type7.
		/// </summary>
		protected readonly Type7 Item7;

		/// <summary>
		/// The storage for type8.
		/// </summary>
		protected readonly Type8 Item8;

		/// <summary>
		/// The storage for type9.
		/// </summary>
		protected readonly Type9 Item9;

        /// <summary>
        /// Conversion from Type1 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(Type1 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(value);
        }

        /// <summary>
        /// Conversion from Type2 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(Type2 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(value);
        }

        /// <summary>
        /// Conversion from Type3 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(Type3 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(value);
        }

        /// <summary>
        /// Conversion from Type4 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(Type4 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(value);
        }

        /// <summary>
        /// Conversion from Type5 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(Type5 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(value);
        }

        /// <summary>
        /// Conversion from Type6 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(Type6 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(value);
        }

        /// <summary>
        /// Conversion from Type7 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(Type7 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(value);
        }

        /// <summary>
        /// Conversion from Type8 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(Type8 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(value);
        }

        /// <summary>
        /// Conversion from Type9 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(Type9 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(value);
        }

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="action5">Action to run for <typeparamref name="Type5"/></param>
		/// <param name="action6">Action to run for <typeparamref name="Type6"/></param>
		/// <param name="action7">Action to run for <typeparamref name="Type7"/></param>
		/// <param name="action8">Action to run for <typeparamref name="Type8"/></param>
		/// <param name="action9">Action to run for <typeparamref name="Type9"/></param>
        public void Match(Action<Type1> action1, Action<Type2> action2, Action<Type3> action3, Action<Type4> action4, Action<Type5> action5, Action<Type6> action6, Action<Type7> action7, Action<Type8> action8, Action<Type9> action9)
		{
			if(action1 == null)
			{
				throw new ArgumentNullException("The argument action1 is null");
			}
			if(action2 == null)
			{
				throw new ArgumentNullException("The argument action2 is null");
			}
			if(action3 == null)
			{
				throw new ArgumentNullException("The argument action3 is null");
			}
			if(action4 == null)
			{
				throw new ArgumentNullException("The argument action4 is null");
			}
			if(action5 == null)
			{
				throw new ArgumentNullException("The argument action5 is null");
			}
			if(action6 == null)
			{
				throw new ArgumentNullException("The argument action6 is null");
			}
			if(action7 == null)
			{
				throw new ArgumentNullException("The argument action7 is null");
			}
			if(action8 == null)
			{
				throw new ArgumentNullException("The argument action8 is null");
			}
			if(action9 == null)
			{
				throw new ArgumentNullException("The argument action9 is null");
			}

            switch (tag)
			{
				case 0: action1(Item1); break;
				case 1: action2(Item2); break;
				case 2: action3(Item3); break;
				case 3: action4(Item4); break;
				case 4: action5(Item5); break;
				case 5: action6(Item6); break;
				case 6: action7(Item7); break;
				case 7: action8(Item8); break;
				case 8: action9(Item9); break;
                default: throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}
	}
	/// <summary>
	/// A Discriminated union for <<NumberOfTypes>> types.
	/// </summary>
    /// <typeparam name="Type1">Type0</typeparam>
    /// <typeparam name="Type2">Type1</typeparam>
    /// <typeparam name="Type3">Type2</typeparam>
    /// <typeparam name="Type4">Type3</typeparam>
    /// <typeparam name="Type5">Type4</typeparam>
    /// <typeparam name="Type6">Type5</typeparam>
    /// <typeparam name="Type7">Type6</typeparam>
    /// <typeparam name="Type8">Type7</typeparam>
    /// <typeparam name="Type9">Type8</typeparam>
    /// <typeparam name="Type10">Type9</typeparam>
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
		/// Runs Actions for the matched types.
		/// </summary>
		public DiscriminatedUnion(object value)
		{
			if(value.GetType() == typeof(Type1))
			{
                Item1 = (Type1)value;
				tag = 0;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else if(value.GetType() == typeof(Type2))
			{
				Item2 = (Type2)value;
				tag = 1;
			}
			else
			{
				throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type8 item) { Item8 = item; tag = 7; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type9 item) { Item9 = item; tag = 8; }

		/// <summary>
		/// Creates a new Discriminated union of with <typeparamref name="Type1"/>
		/// </summary>
		/// <param name="item"></param>
		public DiscriminatedUnion(Type10 item) { Item10 = item; tag = 9; }

		/// <summary>
		/// The storage for type1.
		/// </summary>
		protected readonly Type1 Item1;

		/// <summary>
		/// The storage for type2.
		/// </summary>
		protected readonly Type2 Item2;

		/// <summary>
		/// The storage for type3.
		/// </summary>
		protected readonly Type3 Item3;

		/// <summary>
		/// The storage for type4.
		/// </summary>
		protected readonly Type4 Item4;

		/// <summary>
		/// The storage for type5.
		/// </summary>
		protected readonly Type5 Item5;

		/// <summary>
		/// The storage for type6.
		/// </summary>
		protected readonly Type6 Item6;

		/// <summary>
		/// The storage for type7.
		/// </summary>
		protected readonly Type7 Item7;

		/// <summary>
		/// The storage for type8.
		/// </summary>
		protected readonly Type8 Item8;

		/// <summary>
		/// The storage for type9.
		/// </summary>
		protected readonly Type9 Item9;

		/// <summary>
		/// The storage for type10.
		/// </summary>
		protected readonly Type10 Item10;

        /// <summary>
        /// Conversion from Type1 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(Type1 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(value);
        }

        /// <summary>
        /// Conversion from Type2 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(Type2 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(value);
        }

        /// <summary>
        /// Conversion from Type3 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(Type3 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(value);
        }

        /// <summary>
        /// Conversion from Type4 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(Type4 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(value);
        }

        /// <summary>
        /// Conversion from Type5 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(Type5 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(value);
        }

        /// <summary>
        /// Conversion from Type6 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(Type6 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(value);
        }

        /// <summary>
        /// Conversion from Type7 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(Type7 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(value);
        }

        /// <summary>
        /// Conversion from Type8 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(Type8 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(value);
        }

        /// <summary>
        /// Conversion from Type9 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(Type9 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(value);
        }

        /// <summary>
        /// Conversion from Type10 to the Discriminated union
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(Type10 value)
        {
            return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(value);
        }

		/// <summary>
		/// Runs Actions for the matched types.
		/// </summary>
		/// <param name="action1">Action to run for <typeparamref name="Type1"/></param>
		/// <param name="action2">Action to run for <typeparamref name="Type2"/></param>
		/// <param name="action3">Action to run for <typeparamref name="Type3"/></param>
		/// <param name="action4">Action to run for <typeparamref name="Type4"/></param>
		/// <param name="action5">Action to run for <typeparamref name="Type5"/></param>
		/// <param name="action6">Action to run for <typeparamref name="Type6"/></param>
		/// <param name="action7">Action to run for <typeparamref name="Type7"/></param>
		/// <param name="action8">Action to run for <typeparamref name="Type8"/></param>
		/// <param name="action9">Action to run for <typeparamref name="Type9"/></param>
		/// <param name="action10">Action to run for <typeparamref name="Type10"/></param>
        public void Match(Action<Type1> action1, Action<Type2> action2, Action<Type3> action3, Action<Type4> action4, Action<Type5> action5, Action<Type6> action6, Action<Type7> action7, Action<Type8> action8, Action<Type9> action9, Action<Type10> action10)
		{
			if(action1 == null)
			{
				throw new ArgumentNullException("The argument action1 is null");
			}
			if(action2 == null)
			{
				throw new ArgumentNullException("The argument action2 is null");
			}
			if(action3 == null)
			{
				throw new ArgumentNullException("The argument action3 is null");
			}
			if(action4 == null)
			{
				throw new ArgumentNullException("The argument action4 is null");
			}
			if(action5 == null)
			{
				throw new ArgumentNullException("The argument action5 is null");
			}
			if(action6 == null)
			{
				throw new ArgumentNullException("The argument action6 is null");
			}
			if(action7 == null)
			{
				throw new ArgumentNullException("The argument action7 is null");
			}
			if(action8 == null)
			{
				throw new ArgumentNullException("The argument action8 is null");
			}
			if(action9 == null)
			{
				throw new ArgumentNullException("The argument action9 is null");
			}
			if(action10 == null)
			{
				throw new ArgumentNullException("The argument action10 is null");
			}

            switch (tag)
			{
				case 0: action1(Item1); break;
				case 1: action2(Item2); break;
				case 2: action3(Item3); break;
				case 3: action4(Item4); break;
				case 4: action5(Item5); break;
				case 5: action6(Item6); break;
				case 6: action7(Item7); break;
				case 7: action8(Item8); break;
				case 8: action9(Item9); break;
				case 9: action10(Item10); break;
                default: throw new ArgumentOutOfRangeException("Unrecognized tag value: " + tag);
			}
		}
	}

}

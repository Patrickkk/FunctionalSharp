namespace DiscriminatedUnions
{
	using System;


    public class DiscriminatedUnionWithBase<Type1, Type2, BaseType> : DiscriminatedUnion<Type1, Type2>
        where Type1 : BaseType 
        where Type2 : BaseType 
    {
        public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type2 item) : base(item) { }

        public BaseType AnyType
        {
            get
            {
                switch (tag)
                {
					case 0: return Item1;
					case 1: return Item2;
                    default: throw new Exception("Unrecognized tag value: " + tag);
                }
            }
        }
    }

    public class DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType> : DiscriminatedUnion<Type1, Type2, Type3>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
    {
        public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type3 item) : base(item) { }

        public BaseType AnyType
        {
            get
            {
                switch (tag)
                {
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
                    default: throw new Exception("Unrecognized tag value: " + tag);
                }
            }
        }
    }

    public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
    {
        public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type4 item) : base(item) { }

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
                    default: throw new Exception("Unrecognized tag value: " + tag);
                }
            }
        }
    }

    public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
    {
        public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type5 item) : base(item) { }

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
                    default: throw new Exception("Unrecognized tag value: " + tag);
                }
            }
        }
    }

    public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
    {
        public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type5 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type6 item) : base(item) { }

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
                    default: throw new Exception("Unrecognized tag value: " + tag);
                }
            }
        }
    }

    public class DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType> : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>
        where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
        where Type7 : BaseType 
    {
        public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type5 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type6 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type7 item) : base(item) { }

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
                    default: throw new Exception("Unrecognized tag value: " + tag);
                }
            }
        }
    }

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
        public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type5 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type6 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type7 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type8 item) : base(item) { }

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
                    default: throw new Exception("Unrecognized tag value: " + tag);
                }
            }
        }
    }

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
        public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type5 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type6 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type7 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type8 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type9 item) : base(item) { }

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
                    default: throw new Exception("Unrecognized tag value: " + tag);
                }
            }
        }
    }

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
        public DiscriminatedUnionWithBase(Type1 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type2 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type3 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type4 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type5 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type6 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type7 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type8 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type9 item) : base(item) { }
        public DiscriminatedUnionWithBase(Type10 item) : base(item) { }

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
                    default: throw new Exception("Unrecognized tag value: " + tag);
                }
            }
        }
    }
}



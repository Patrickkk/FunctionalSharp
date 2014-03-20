namespace DiscriminatedUnions
{
	using System;

    public class DiscriminatedUnion<Type1, Type2>
    {
	    int tag;

        readonly Type1 Item1;
        public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
        readonly Type2 Item2;
        public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }

        public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2)
        {
            switch (tag)
            {
                case 0: return Function1(Item1);
                case 1: return Function2(Item2);
                default: throw new Exception("Unrecognized tag value: " + tag);
            }
        }
    }


    public class DiscriminatedUnion<Type1, Type2, Type3>
    {
	    int tag;

        readonly Type1 Item1;
        public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
        readonly Type2 Item2;
        public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
        readonly Type3 Item3;
        public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }

        public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3)
        {
            switch (tag)
            {
                case 0: return Function1(Item1);
                case 1: return Function2(Item2);
                case 2: return Function3(Item3);
                default: throw new Exception("Unrecognized tag value: " + tag);
            }
        }
    }


    public class DiscriminatedUnion<Type1, Type2, Type3, Type4>
    {
	    int tag;

        readonly Type1 Item1;
        public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
        readonly Type2 Item2;
        public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
        readonly Type3 Item3;
        public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
        readonly Type4 Item4;
        public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }

        public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4)
        {
            switch (tag)
            {
                case 0: return Function1(Item1);
                case 1: return Function2(Item2);
                case 2: return Function3(Item3);
                case 3: return Function4(Item4);
                default: throw new Exception("Unrecognized tag value: " + tag);
            }
        }
    }


    public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>
    {
	    int tag;

        readonly Type1 Item1;
        public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
        readonly Type2 Item2;
        public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
        readonly Type3 Item3;
        public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
        readonly Type4 Item4;
        public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
        readonly Type5 Item5;
        public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }

        public ReturnType Match<ReturnType>(Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5)
        {
            switch (tag)
            {
                case 0: return Function1(Item1);
                case 1: return Function2(Item2);
                case 2: return Function3(Item3);
                case 3: return Function4(Item4);
                case 4: return Function5(Item5);
                default: throw new Exception("Unrecognized tag value: " + tag);
            }
        }
    }


    public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>
    {
	    int tag;

        readonly Type1 Item1;
        public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
        readonly Type2 Item2;
        public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
        readonly Type3 Item3;
        public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
        readonly Type4 Item4;
        public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
        readonly Type5 Item5;
        public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
        readonly Type6 Item6;
        public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }

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
                default: throw new Exception("Unrecognized tag value: " + tag);
            }
        }
    }


    public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>
    {
	    int tag;

        readonly Type1 Item1;
        public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
        readonly Type2 Item2;
        public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
        readonly Type3 Item3;
        public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
        readonly Type4 Item4;
        public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
        readonly Type5 Item5;
        public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
        readonly Type6 Item6;
        public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }
        readonly Type7 Item7;
        public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }

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
                default: throw new Exception("Unrecognized tag value: " + tag);
            }
        }
    }


    public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>
    {
	    int tag;

        readonly Type1 Item1;
        public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
        readonly Type2 Item2;
        public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
        readonly Type3 Item3;
        public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
        readonly Type4 Item4;
        public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
        readonly Type5 Item5;
        public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
        readonly Type6 Item6;
        public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }
        readonly Type7 Item7;
        public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }
        readonly Type8 Item8;
        public DiscriminatedUnion(Type8 item) { Item8 = item; tag = 7; }

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
                default: throw new Exception("Unrecognized tag value: " + tag);
            }
        }
    }


    public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>
    {
	    int tag;

        readonly Type1 Item1;
        public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
        readonly Type2 Item2;
        public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
        readonly Type3 Item3;
        public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
        readonly Type4 Item4;
        public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
        readonly Type5 Item5;
        public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
        readonly Type6 Item6;
        public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }
        readonly Type7 Item7;
        public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }
        readonly Type8 Item8;
        public DiscriminatedUnion(Type8 item) { Item8 = item; tag = 7; }
        readonly Type9 Item9;
        public DiscriminatedUnion(Type9 item) { Item9 = item; tag = 8; }

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
                default: throw new Exception("Unrecognized tag value: " + tag);
            }
        }
    }


    public class DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>
    {
	    int tag;

        readonly Type1 Item1;
        public DiscriminatedUnion(Type1 item) { Item1 = item; tag = 0; }
        readonly Type2 Item2;
        public DiscriminatedUnion(Type2 item) { Item2 = item; tag = 1; }
        readonly Type3 Item3;
        public DiscriminatedUnion(Type3 item) { Item3 = item; tag = 2; }
        readonly Type4 Item4;
        public DiscriminatedUnion(Type4 item) { Item4 = item; tag = 3; }
        readonly Type5 Item5;
        public DiscriminatedUnion(Type5 item) { Item5 = item; tag = 4; }
        readonly Type6 Item6;
        public DiscriminatedUnion(Type6 item) { Item6 = item; tag = 5; }
        readonly Type7 Item7;
        public DiscriminatedUnion(Type7 item) { Item7 = item; tag = 6; }
        readonly Type8 Item8;
        public DiscriminatedUnion(Type8 item) { Item8 = item; tag = 7; }
        readonly Type9 Item9;
        public DiscriminatedUnion(Type9 item) { Item9 = item; tag = 8; }
        readonly Type10 Item10;
        public DiscriminatedUnion(Type10 item) { Item10 = item; tag = 9; }

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
                default: throw new Exception("Unrecognized tag value: " + tag);
            }
        }
    }

}

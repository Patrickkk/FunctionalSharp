





namespace DiscriminatedUnions
{
	using System;
	using System.Linq;
    using System.Collections.Generic;

	public static class DiscriminatedUnionListExtensions
	{

		public static void Match<Type1, Type2>(this List<DiscriminatedUnion<Type1, Type2>> values,  Action<Type1> Action1, Action<Type2> Action2)
        {
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, ReturnType>(this List<DiscriminatedUnion<Type1, Type2>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2)
        {
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item)
            ));
        }

		public static void Match<Type1, Type2, BaseType>(this List<DiscriminatedUnionWithBase<Type1, Type2, BaseType>> values,Action<Type1> Action1, Action<Type2> Action2)
                where Type1 : BaseType 
        where Type2 : BaseType 
		{
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, BaseType, ReturnType>(this List<DiscriminatedUnionWithBase<Type1, Type2, BaseType>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2)
                where Type1 : BaseType 
        where Type2 : BaseType 
		{
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item)
            ));
        }

		public static void Match<Type1, Type2, Type3>(this List<DiscriminatedUnion<Type1, Type2, Type3>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3)
        {
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, ReturnType>(this List<DiscriminatedUnion<Type1, Type2, Type3>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3)
        {
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, BaseType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>> values,Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
		{
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, BaseType, ReturnType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, BaseType>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
		{
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4)
        {
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, ReturnType>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4)
        {
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, BaseType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>> values,Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
		{
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, BaseType, ReturnType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, BaseType>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
		{
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5)
        {
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, ReturnType>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5)
        {
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, BaseType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>> values,Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
		{
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, BaseType, ReturnType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, BaseType>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
		{
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6)
        {
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, ReturnType>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6)
        {
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>> values,Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
		{
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, BaseType, ReturnType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, BaseType>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
		{
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7)
        {
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, ReturnType>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7)
        {
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>> values,Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
        where Type7 : BaseType 
		{
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType, ReturnType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, BaseType>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
        where Type7 : BaseType 
		{
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8)
        {
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item),
                type8Item => Action8(type8Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, ReturnType>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8)
        {
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item),
                type8Item => Function8(type8Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>> values,Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
        where Type7 : BaseType 
        where Type8 : BaseType 
		{
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item),
                type8Item => Action8(type8Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType, ReturnType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, BaseType>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8)
                where Type1 : BaseType 
        where Type2 : BaseType 
        where Type3 : BaseType 
        where Type4 : BaseType 
        where Type5 : BaseType 
        where Type6 : BaseType 
        where Type7 : BaseType 
        where Type8 : BaseType 
		{
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item),
                type8Item => Function8(type8Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8, Action<Type9> Action9)
        {
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item),
                type8Item => Action8(type8Item),
                type9Item => Action9(type9Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, ReturnType>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8, Func<Type9, ReturnType> Function9)
        {
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item),
                type8Item => Function8(type8Item),
                type9Item => Function9(type9Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>> values,Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8, Action<Type9> Action9)
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
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item),
                type8Item => Action8(type8Item),
                type9Item => Action9(type9Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType, ReturnType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, BaseType>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8, Func<Type9, ReturnType> Function9)
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
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item),
                type8Item => Function8(type8Item),
                type9Item => Function9(type9Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8, Action<Type9> Action9, Action<Type10> Action10)
        {
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item),
                type8Item => Action8(type8Item),
                type9Item => Action9(type9Item),
                type10Item => Action10(type10Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, ReturnType>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8, Func<Type9, ReturnType> Function9, Func<Type10, ReturnType> Function10)
        {
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item),
                type8Item => Function8(type8Item),
                type9Item => Function9(type9Item),
                type10Item => Function10(type10Item)
            ));
        }

		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>> values,Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8, Action<Type9> Action9, Action<Type10> Action10)
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
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item),
                type3Item => Action3(type3Item),
                type4Item => Action4(type4Item),
                type5Item => Action5(type5Item),
                type6Item => Action6(type6Item),
                type7Item => Action7(type7Item),
                type8Item => Action8(type8Item),
                type9Item => Action9(type9Item),
                type10Item => Action10(type10Item)
            ));
        }

        public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType, ReturnType>(this List<DiscriminatedUnionWithBase<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10, BaseType>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8, Func<Type9, ReturnType> Function9, Func<Type10, ReturnType> Function10)
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
            return values.Select(item => item.Match(
                type1Item => Function1(type1Item),
                type2Item => Function2(type2Item),
                type3Item => Function3(type3Item),
                type4Item => Function4(type4Item),
                type5Item => Function5(type5Item),
                type6Item => Function6(type6Item),
                type7Item => Function7(type7Item),
                type8Item => Function8(type8Item),
                type9Item => Function9(type9Item),
                type10Item => Function10(type10Item)
            ));
        }

	}
}

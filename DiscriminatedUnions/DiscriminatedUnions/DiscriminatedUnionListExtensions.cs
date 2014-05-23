





namespace DiscriminatedUnions
{
	using System;
	using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Provides extension methods to Match, Add, Add a range to lists of discriminated unions.
    /// </summary>
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

		/// <summary>
        /// Runs actions for the specific matching types.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Action1">The action to run for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Action2">The action to run for <typeparamref name="Type2"></typeparamref></param>

		public static void Match<Type1, Type2, BaseType>(this List<DiscriminatedUnionWithBase<Type1, Type2, BaseType>> values,Action<Type1> Action1, Action<Type2> Action2)
                where Type1 : BaseType 
        where Type2 : BaseType 
		{
            values.ForEach(item => item.Match(
                type1Item => Action1(type1Item),
                type2Item => Action2(type2Item)
            ));
        }

		/// <summary>
        /// Transforms the list matching the specific types and extecuting a function for them.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <typeparam name="ReturnType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Function1">The function to execute for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Function2">The function to execute for <typeparamref name="Type2"></typeparamref></param>
        /// <returns><typeparamref name="ReturnType"></typeparamref></returns>
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

		/// <summary>
        /// Runs actions for the specific matching types.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Action1">The action to run for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Action2">The action to run for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Action3">The action to run for <typeparamref name="Type3"></typeparamref></param>

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

		/// <summary>
        /// Transforms the list matching the specific types and extecuting a function for them.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <typeparam name="ReturnType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Function1">The function to execute for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Function2">The function to execute for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Function3">The function to execute for <typeparamref name="Type3"></typeparamref></param>
        /// <returns><typeparamref name="ReturnType"></typeparamref></returns>
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

		/// <summary>
        /// Runs actions for the specific matching types.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Action1">The action to run for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Action2">The action to run for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Action3">The action to run for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Action4">The action to run for <typeparamref name="Type4"></typeparamref></param>

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

		/// <summary>
        /// Transforms the list matching the specific types and extecuting a function for them.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <typeparam name="ReturnType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Function1">The function to execute for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Function2">The function to execute for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Function3">The function to execute for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Function4">The function to execute for <typeparamref name="Type4"></typeparamref></param>
        /// <returns><typeparamref name="ReturnType"></typeparamref></returns>
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

		/// <summary>
        /// Runs actions for the specific matching types.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Action1">The action to run for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Action2">The action to run for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Action3">The action to run for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Action4">The action to run for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Action5">The action to run for <typeparamref name="Type5"></typeparamref></param>

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

		/// <summary>
        /// Transforms the list matching the specific types and extecuting a function for them.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <typeparam name="ReturnType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Function1">The function to execute for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Function2">The function to execute for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Function3">The function to execute for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Function4">The function to execute for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Function5">The function to execute for <typeparamref name="Type5"></typeparamref></param>
        /// <returns><typeparamref name="ReturnType"></typeparamref></returns>
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

		/// <summary>
        /// Runs actions for the specific matching types.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Action1">The action to run for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Action2">The action to run for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Action3">The action to run for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Action4">The action to run for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Action5">The action to run for <typeparamref name="Type5"></typeparamref></param>
        /// <param name="Action6">The action to run for <typeparamref name="Type6"></typeparamref></param>

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

		/// <summary>
        /// Transforms the list matching the specific types and extecuting a function for them.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <typeparam name="ReturnType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Function1">The function to execute for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Function2">The function to execute for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Function3">The function to execute for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Function4">The function to execute for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Function5">The function to execute for <typeparamref name="Type5"></typeparamref></param>
        /// <param name="Function6">The function to execute for <typeparamref name="Type6"></typeparamref></param>
        /// <returns><typeparamref name="ReturnType"></typeparamref></returns>
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

		/// <summary>
        /// Runs actions for the specific matching types.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Action1">The action to run for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Action2">The action to run for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Action3">The action to run for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Action4">The action to run for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Action5">The action to run for <typeparamref name="Type5"></typeparamref></param>
        /// <param name="Action6">The action to run for <typeparamref name="Type6"></typeparamref></param>
        /// <param name="Action7">The action to run for <typeparamref name="Type7"></typeparamref></param>

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

		/// <summary>
        /// Transforms the list matching the specific types and extecuting a function for them.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="BaseType"></typeparam>
        /// <typeparam name="ReturnType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Function1">The function to execute for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Function2">The function to execute for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Function3">The function to execute for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Function4">The function to execute for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Function5">The function to execute for <typeparamref name="Type5"></typeparamref></param>
        /// <param name="Function6">The function to execute for <typeparamref name="Type6"></typeparamref></param>
        /// <param name="Function7">The function to execute for <typeparamref name="Type7"></typeparamref></param>
        /// <returns><typeparamref name="ReturnType"></typeparamref></returns>
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

		/// <summary>
        /// Runs actions for the specific matching types.
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
        /// <param name="values"></param>
        /// <param name="Action1">The action to run for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Action2">The action to run for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Action3">The action to run for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Action4">The action to run for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Action5">The action to run for <typeparamref name="Type5"></typeparamref></param>
        /// <param name="Action6">The action to run for <typeparamref name="Type6"></typeparamref></param>
        /// <param name="Action7">The action to run for <typeparamref name="Type7"></typeparamref></param>
        /// <param name="Action8">The action to run for <typeparamref name="Type8"></typeparamref></param>

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

		/// <summary>
        /// Transforms the list matching the specific types and extecuting a function for them.
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
        /// <typeparam name="ReturnType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Function1">The function to execute for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Function2">The function to execute for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Function3">The function to execute for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Function4">The function to execute for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Function5">The function to execute for <typeparamref name="Type5"></typeparamref></param>
        /// <param name="Function6">The function to execute for <typeparamref name="Type6"></typeparamref></param>
        /// <param name="Function7">The function to execute for <typeparamref name="Type7"></typeparamref></param>
        /// <param name="Function8">The function to execute for <typeparamref name="Type8"></typeparamref></param>
        /// <returns><typeparamref name="ReturnType"></typeparamref></returns>
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

		/// <summary>
        /// Runs actions for the specific matching types.
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
        /// <param name="values"></param>
        /// <param name="Action1">The action to run for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Action2">The action to run for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Action3">The action to run for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Action4">The action to run for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Action5">The action to run for <typeparamref name="Type5"></typeparamref></param>
        /// <param name="Action6">The action to run for <typeparamref name="Type6"></typeparamref></param>
        /// <param name="Action7">The action to run for <typeparamref name="Type7"></typeparamref></param>
        /// <param name="Action8">The action to run for <typeparamref name="Type8"></typeparamref></param>
        /// <param name="Action9">The action to run for <typeparamref name="Type9"></typeparamref></param>

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

		/// <summary>
        /// Transforms the list matching the specific types and extecuting a function for them.
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
        /// <typeparam name="ReturnType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Function1">The function to execute for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Function2">The function to execute for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Function3">The function to execute for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Function4">The function to execute for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Function5">The function to execute for <typeparamref name="Type5"></typeparamref></param>
        /// <param name="Function6">The function to execute for <typeparamref name="Type6"></typeparamref></param>
        /// <param name="Function7">The function to execute for <typeparamref name="Type7"></typeparamref></param>
        /// <param name="Function8">The function to execute for <typeparamref name="Type8"></typeparamref></param>
        /// <param name="Function9">The function to execute for <typeparamref name="Type9"></typeparamref></param>
        /// <returns><typeparamref name="ReturnType"></typeparamref></returns>
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

		/// <summary>
        /// Runs actions for the specific matching types.
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
        /// <param name="values"></param>
        /// <param name="Action1">The action to run for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Action2">The action to run for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Action3">The action to run for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Action4">The action to run for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Action5">The action to run for <typeparamref name="Type5"></typeparamref></param>
        /// <param name="Action6">The action to run for <typeparamref name="Type6"></typeparamref></param>
        /// <param name="Action7">The action to run for <typeparamref name="Type7"></typeparamref></param>
        /// <param name="Action8">The action to run for <typeparamref name="Type8"></typeparamref></param>
        /// <param name="Action9">The action to run for <typeparamref name="Type9"></typeparamref></param>
        /// <param name="Action10">The action to run for <typeparamref name="Type10"></typeparamref></param>

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

		/// <summary>
        /// Transforms the list matching the specific types and extecuting a function for them.
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
        /// <typeparam name="ReturnType"></typeparam>
        /// <param name="values"></param>
        /// <param name="Function1">The function to execute for <typeparamref name="Type1"></typeparamref></param>
        /// <param name="Function2">The function to execute for <typeparamref name="Type2"></typeparamref></param>
        /// <param name="Function3">The function to execute for <typeparamref name="Type3"></typeparamref></param>
        /// <param name="Function4">The function to execute for <typeparamref name="Type4"></typeparamref></param>
        /// <param name="Function5">The function to execute for <typeparamref name="Type5"></typeparamref></param>
        /// <param name="Function6">The function to execute for <typeparamref name="Type6"></typeparamref></param>
        /// <param name="Function7">The function to execute for <typeparamref name="Type7"></typeparamref></param>
        /// <param name="Function8">The function to execute for <typeparamref name="Type8"></typeparamref></param>
        /// <param name="Function9">The function to execute for <typeparamref name="Type9"></typeparamref></param>
        /// <param name="Function10">The function to execute for <typeparamref name="Type10"></typeparamref></param>
        /// <returns><typeparamref name="ReturnType"></typeparamref></returns>
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


        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2>(this List<DiscriminatedUnion<Type1, Type2>> values ,Type1 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2>(this List<DiscriminatedUnion<Type1, Type2>> values ,IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2>(this List<DiscriminatedUnion<Type1, Type2>> values ,Type2 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2>(this List<DiscriminatedUnion<Type1, Type2>> values ,IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }

        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3>(this List<DiscriminatedUnion<Type1, Type2, Type3>> values ,Type1 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3>(this List<DiscriminatedUnion<Type1, Type2, Type3>> values ,IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3>(this List<DiscriminatedUnion<Type1, Type2, Type3>> values ,Type2 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3>(this List<DiscriminatedUnion<Type1, Type2, Type3>> values ,IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3>(this List<DiscriminatedUnion<Type1, Type2, Type3>> values ,Type3 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3>(this List<DiscriminatedUnion<Type1, Type2, Type3>> values ,IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }

        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values ,Type1 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values ,IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values ,Type2 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values ,IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values ,Type3 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values ,IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values ,Type4 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values ,IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }

        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values ,Type1 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values ,IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values ,Type2 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values ,IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values ,Type3 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values ,IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values ,Type4 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values ,IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values ,Type5 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values ,IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }

        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,Type1 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,Type2 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,Type3 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,Type4 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,Type5 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,Type6 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values ,IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }

        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,Type1 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,Type2 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,Type3 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,Type4 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,Type5 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,Type6 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,Type7 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values ,IEnumerable<Type7> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }

        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,Type1 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,Type2 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,Type3 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,Type4 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,Type5 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,Type6 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,Type7 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,IEnumerable<Type7> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,Type8 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values ,IEnumerable<Type8> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }

        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,Type1 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,Type2 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,Type3 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,Type4 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,Type5 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,Type6 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,Type7 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,IEnumerable<Type7> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,Type8 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,IEnumerable<Type8> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,Type9 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values ,IEnumerable<Type9> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }

        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,Type1 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <typeparam name="Type10"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,IEnumerable<Type1> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,Type2 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <typeparam name="Type10"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,IEnumerable<Type2> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,Type3 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <typeparam name="Type10"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,IEnumerable<Type3> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,Type4 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <typeparam name="Type10"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,IEnumerable<Type4> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,Type5 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <typeparam name="Type10"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,IEnumerable<Type5> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,Type6 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <typeparam name="Type10"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,IEnumerable<Type6> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,Type7 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <typeparam name="Type10"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,IEnumerable<Type7> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,Type8 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <typeparam name="Type10"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,IEnumerable<Type8> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,Type9 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <typeparam name="Type10"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,IEnumerable<Type9> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }
        /// <summary>
        /// Adds the object to the end of the DiscriminatedUnionList
        /// </summary>
		/// <param name="values">the List to add the items to.</param>
        /// <param name="item"></param>
        public static void Add<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,Type10 item)
        {
            values.Add(new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item));
        }

        /// <summary>
        /// Adds a Enumerable of items to the list.
        /// </summary>
        /// <typeparam name="Type1"></typeparam>
        /// <typeparam name="Type2"></typeparam>
        /// <typeparam name="Type3"></typeparam>
        /// <typeparam name="Type4"></typeparam>
        /// <typeparam name="Type5"></typeparam>
        /// <typeparam name="Type6"></typeparam>
        /// <typeparam name="Type7"></typeparam>
        /// <typeparam name="Type8"></typeparam>
        /// <typeparam name="Type9"></typeparam>
        /// <typeparam name="Type10"></typeparam>
        /// <param name="values">the List to add the items to.</param>
        /// <param name="collectionToAdd">The items to add.</param>
		public static void AddRange<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this List<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> values ,IEnumerable<Type10> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                values.Add(item);
            }
        }

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> Merge<Type1, Type2, Type3>(this IEnumerable<DiscriminatedUnion<Type1, Type2>> values, Type3 newType)
        {
			return values.Merge((IEnumerable<Type3>)new List<Type3>{ newType });
		}

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> Merge<Type1, Type2, Type3>(this IEnumerable<DiscriminatedUnion<Type1, Type2>> values, IEnumerable<Type3> newTypes)
        {
            foreach (var item in values)
            {
			     yield return item.Match(
                     type1Item => new DiscriminatedUnion<Type1, Type2, Type3>(type1Item),
                     type2Item => new DiscriminatedUnion<Type1, Type2, Type3>(type2Item));
            }
            foreach (var item in newTypes)
            {
                yield return new DiscriminatedUnion<Type1, Type2, Type3>(item);
            }
        }

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> Merge<Type1, Type2, Type3, Type4>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> values, Type4 newType)
        {
			return values.Merge((IEnumerable<Type4>)new List<Type4>{ newType });
		}

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> Merge<Type1, Type2, Type3, Type4>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> values, IEnumerable<Type4> newTypes)
        {
            foreach (var item in values)
            {
			     yield return item.Match(
                     type1Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4>(type1Item),
                     type2Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4>(type2Item),
                     type3Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4>(type3Item));
            }
            foreach (var item in newTypes)
            {
                yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item);
            }
        }

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> Merge<Type1, Type2, Type3, Type4, Type5>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values, Type5 newType)
        {
			return values.Merge((IEnumerable<Type5>)new List<Type5>{ newType });
		}

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> Merge<Type1, Type2, Type3, Type4, Type5>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values, IEnumerable<Type5> newTypes)
        {
            foreach (var item in values)
            {
			     yield return item.Match(
                     type1Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type1Item),
                     type2Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type2Item),
                     type3Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type3Item),
                     type4Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type4Item));
            }
            foreach (var item in newTypes)
            {
                yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item);
            }
        }

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> Merge<Type1, Type2, Type3, Type4, Type5, Type6>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values, Type6 newType)
        {
			return values.Merge((IEnumerable<Type6>)new List<Type6>{ newType });
		}

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> Merge<Type1, Type2, Type3, Type4, Type5, Type6>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values, IEnumerable<Type6> newTypes)
        {
            foreach (var item in values)
            {
			     yield return item.Match(
                     type1Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type1Item),
                     type2Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type2Item),
                     type3Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type3Item),
                     type4Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type4Item),
                     type5Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type5Item));
            }
            foreach (var item in newTypes)
            {
                yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item);
            }
        }

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values, Type7 newType)
        {
			return values.Merge((IEnumerable<Type7>)new List<Type7>{ newType });
		}

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values, IEnumerable<Type7> newTypes)
        {
            foreach (var item in values)
            {
			     yield return item.Match(
                     type1Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type1Item),
                     type2Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type2Item),
                     type3Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type3Item),
                     type4Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type4Item),
                     type5Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type5Item),
                     type6Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type6Item));
            }
            foreach (var item in newTypes)
            {
                yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item);
            }
        }

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values, Type8 newType)
        {
			return values.Merge((IEnumerable<Type8>)new List<Type8>{ newType });
		}

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values, IEnumerable<Type8> newTypes)
        {
            foreach (var item in values)
            {
			     yield return item.Match(
                     type1Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type1Item),
                     type2Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type2Item),
                     type3Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type3Item),
                     type4Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type4Item),
                     type5Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type5Item),
                     type6Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type6Item),
                     type7Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type7Item));
            }
            foreach (var item in newTypes)
            {
                yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item);
            }
        }

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values, Type9 newType)
        {
			return values.Merge((IEnumerable<Type9>)new List<Type9>{ newType });
		}

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values, IEnumerable<Type9> newTypes)
        {
            foreach (var item in values)
            {
			     yield return item.Match(
                     type1Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type1Item),
                     type2Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type2Item),
                     type3Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type3Item),
                     type4Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type4Item),
                     type5Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type5Item),
                     type6Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type6Item),
                     type7Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type7Item),
                     type8Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type8Item));
            }
            foreach (var item in newTypes)
            {
                yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item);
            }
        }

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values, Type10 newType)
        {
			return values.Merge((IEnumerable<Type10>)new List<Type10>{ newType });
		}

        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values, IEnumerable<Type10> newTypes)
        {
            foreach (var item in values)
            {
			     yield return item.Match(
                     type1Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(type1Item),
                     type2Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(type2Item),
                     type3Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(type3Item),
                     type4Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(type4Item),
                     type5Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(type5Item),
                     type6Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(type6Item),
                     type7Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(type7Item),
                     type8Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(type8Item),
                     type9Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(type9Item));
            }
            foreach (var item in newTypes)
            {
                yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item);
            }
        }


	}
}

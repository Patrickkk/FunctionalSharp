





namespace FunctionalSharp.DiscriminatedUnions
{
	using System;
	using System.Linq;
	using System.Collections.Generic;

	/// <summary>
	/// Provides extension methods to the IEnumerable of DiscriminatedUnion.
	/// </summary>
	public static class DiscriminatedUnionIEnumerableExtensions
	{
		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<TUnion,Type1, Type2>(this IEnumerable<TUnion> values,  Action<Type1> Action1, Action<Type2> Action2)
		where TUnion : DiscriminatedUnion<Type1, Type2>
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item));
			}
		}

				/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<TUnion,Type1, Type2, ReturnType>(this IEnumerable<TUnion> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2)
			where TUnion : DiscriminatedUnion<Type1, Type2>
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item));
			}
		}

		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<Type1, Type2>(this IEnumerable<DiscriminatedUnion<Type1, Type2>> values,  Action<Type1> Action1, Action<Type2> Action2)
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item));
			}
		}

		/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<Type1, Type2, ReturnType>(this IEnumerable<DiscriminatedUnion<Type1, Type2>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2)
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item));
			}
		}

		/// <summary>
		/// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="item"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> MergeItem<Type1, Type2, Type3>(this IEnumerable<DiscriminatedUnion<Type1, Type2>> values, Type3 item)
		{
			return values.Merge((IEnumerable<Type3>)new List<Type3>{ item });
		}

		/// <summary>
		/// Merges the item intos the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the items as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="items"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> Merge<Type1, Type2, Type3>(this IEnumerable<DiscriminatedUnion<Type1, Type2>> values, IEnumerable<Type3> items)
		{
			foreach (var item in values)
			{
				 yield return item.Match(
					 type1Item => new DiscriminatedUnion<Type1, Type2, Type3>(type1Item),
					 type2Item => new DiscriminatedUnion<Type1, Type2, Type3>(type2Item));
			}
			foreach (var item in items)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3>(item);
			}
		}

				/// <summary>
		/// Merges to given collections into a discriminated union collection.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
		/// <param name="type1Values">a collection to merge</param>
		/// <param name="type2Values">a collection to merge</param>
		/// <returns>Discriminated unions of all types.</returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2>> Merge<Type1, Type2>(this IEnumerable<Type1> type1Values, IEnumerable<Type2> type2Values)
		{
			foreach (var type1Value in type1Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2>(type1Value);
			}
			foreach (var type2Value in type2Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2>(type2Value);
			}
		}
		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<TUnion,Type1, Type2, Type3>(this IEnumerable<TUnion> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3)
		where TUnion : DiscriminatedUnion<Type1, Type2, Type3>
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item));
			}
		}

				/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<TUnion,Type1, Type2, Type3, ReturnType>(this IEnumerable<TUnion> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3)
			where TUnion : DiscriminatedUnion<Type1, Type2, Type3>
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item));
			}
		}

		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<Type1, Type2, Type3>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3)
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item));
			}
		}

		/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, ReturnType>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3)
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item));
			}
		}

		/// <summary>
		/// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="item"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> MergeItem<Type1, Type2, Type3, Type4>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> values, Type4 item)
		{
			return values.Merge((IEnumerable<Type4>)new List<Type4>{ item });
		}

		/// <summary>
		/// Merges the item intos the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the items as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="items"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> Merge<Type1, Type2, Type3, Type4>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> values, IEnumerable<Type4> items)
		{
			foreach (var item in values)
			{
				 yield return item.Match(
					 type1Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4>(type1Item),
					 type2Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4>(type2Item),
					 type3Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4>(type3Item));
			}
			foreach (var item in items)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4>(item);
			}
		}

				/// <summary>
		/// Merges to given collections into a discriminated union collection.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
		/// <param name="type1Values">a collection to merge</param>
		/// <param name="type2Values">a collection to merge</param>
		/// <param name="type3Values">a collection to merge</param>
		/// <returns>Discriminated unions of all types.</returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> Merge<Type1, Type2, Type3>(this IEnumerable<Type1> type1Values, IEnumerable<Type2> type2Values, IEnumerable<Type3> type3Values)
		{
			foreach (var type1Value in type1Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3>(type1Value);
			}
			foreach (var type2Value in type2Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3>(type2Value);
			}
			foreach (var type3Value in type3Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3>(type3Value);
			}
		}
		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<TUnion,Type1, Type2, Type3, Type4>(this IEnumerable<TUnion> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4)
		where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4>
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item));
			}
		}

				/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<TUnion,Type1, Type2, Type3, Type4, ReturnType>(this IEnumerable<TUnion> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4)
			where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4>
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item));
			}
		}

		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<Type1, Type2, Type3, Type4>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4)
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item));
			}
		}

		/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, ReturnType>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4)
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item));
			}
		}

		/// <summary>
		/// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="item"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> MergeItem<Type1, Type2, Type3, Type4, Type5>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values, Type5 item)
		{
			return values.Merge((IEnumerable<Type5>)new List<Type5>{ item });
		}

		/// <summary>
		/// Merges the item intos the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the items as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="items"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> Merge<Type1, Type2, Type3, Type4, Type5>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values, IEnumerable<Type5> items)
		{
			foreach (var item in values)
			{
				 yield return item.Match(
					 type1Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type1Item),
					 type2Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type2Item),
					 type3Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type3Item),
					 type4Item => new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type4Item));
			}
			foreach (var item in items)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(item);
			}
		}

				/// <summary>
		/// Merges to given collections into a discriminated union collection.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
		/// <param name="type1Values">a collection to merge</param>
		/// <param name="type2Values">a collection to merge</param>
		/// <param name="type3Values">a collection to merge</param>
		/// <param name="type4Values">a collection to merge</param>
		/// <returns>Discriminated unions of all types.</returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> Merge<Type1, Type2, Type3, Type4>(this IEnumerable<Type1> type1Values, IEnumerable<Type2> type2Values, IEnumerable<Type3> type3Values, IEnumerable<Type4> type4Values)
		{
			foreach (var type1Value in type1Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4>(type1Value);
			}
			foreach (var type2Value in type2Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4>(type2Value);
			}
			foreach (var type3Value in type3Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4>(type3Value);
			}
			foreach (var type4Value in type4Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4>(type4Value);
			}
		}
		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="Action5">Action to run for Type5</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<TUnion,Type1, Type2, Type3, Type4, Type5>(this IEnumerable<TUnion> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5)
		where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item),
				type5Item => Action5(type5Item));
			}
		}

				/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="Function5">Function to run for Type5</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<TUnion,Type1, Type2, Type3, Type4, Type5, ReturnType>(this IEnumerable<TUnion> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5)
			where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item),
				type5Item => Function5(type5Item));
			}
		}

		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="Action5">Action to run for Type5</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<Type1, Type2, Type3, Type4, Type5>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5)
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item),
				type5Item => Action5(type5Item));
			}
		}

		/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="Function5">Function to run for Type5</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, ReturnType>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5)
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item),
				type5Item => Function5(type5Item));
			}
		}

		/// <summary>
		/// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="item"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> MergeItem<Type1, Type2, Type3, Type4, Type5, Type6>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values, Type6 item)
		{
			return values.Merge((IEnumerable<Type6>)new List<Type6>{ item });
		}

		/// <summary>
		/// Merges the item intos the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the items as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="items"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> Merge<Type1, Type2, Type3, Type4, Type5, Type6>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values, IEnumerable<Type6> items)
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
			foreach (var item in items)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(item);
			}
		}

				/// <summary>
		/// Merges to given collections into a discriminated union collection.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
		/// <param name="type1Values">a collection to merge</param>
		/// <param name="type2Values">a collection to merge</param>
		/// <param name="type3Values">a collection to merge</param>
		/// <param name="type4Values">a collection to merge</param>
		/// <param name="type5Values">a collection to merge</param>
		/// <returns>Discriminated unions of all types.</returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> Merge<Type1, Type2, Type3, Type4, Type5>(this IEnumerable<Type1> type1Values, IEnumerable<Type2> type2Values, IEnumerable<Type3> type3Values, IEnumerable<Type4> type4Values, IEnumerable<Type5> type5Values)
		{
			foreach (var type1Value in type1Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type1Value);
			}
			foreach (var type2Value in type2Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type2Value);
			}
			foreach (var type3Value in type3Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type3Value);
			}
			foreach (var type4Value in type4Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type4Value);
			}
			foreach (var type5Value in type5Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>(type5Value);
			}
		}
		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="Action5">Action to run for Type5</param>
		/// <param name="Action6">Action to run for Type6</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<TUnion,Type1, Type2, Type3, Type4, Type5, Type6>(this IEnumerable<TUnion> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6)
		where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item),
				type5Item => Action5(type5Item),
				type6Item => Action6(type6Item));
			}
		}

				/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="Function5">Function to run for Type5</param>
		/// <param name="Function6">Function to run for Type6</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<TUnion,Type1, Type2, Type3, Type4, Type5, Type6, ReturnType>(this IEnumerable<TUnion> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6)
			where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item),
				type5Item => Function5(type5Item),
				type6Item => Function6(type6Item));
			}
		}

		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="Action5">Action to run for Type5</param>
		/// <param name="Action6">Action to run for Type6</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6)
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item),
				type5Item => Action5(type5Item),
				type6Item => Action6(type6Item));
			}
		}

		/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="Function5">Function to run for Type5</param>
		/// <param name="Function6">Function to run for Type6</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, ReturnType>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6)
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item),
				type5Item => Function5(type5Item),
				type6Item => Function6(type6Item));
			}
		}

		/// <summary>
		/// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="item"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> MergeItem<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values, Type7 item)
		{
			return values.Merge((IEnumerable<Type7>)new List<Type7>{ item });
		}

		/// <summary>
		/// Merges the item intos the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the items as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="items"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values, IEnumerable<Type7> items)
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
			foreach (var item in items)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(item);
			}
		}

				/// <summary>
		/// Merges to given collections into a discriminated union collection.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
		/// <param name="type1Values">a collection to merge</param>
		/// <param name="type2Values">a collection to merge</param>
		/// <param name="type3Values">a collection to merge</param>
		/// <param name="type4Values">a collection to merge</param>
		/// <param name="type5Values">a collection to merge</param>
		/// <param name="type6Values">a collection to merge</param>
		/// <returns>Discriminated unions of all types.</returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> Merge<Type1, Type2, Type3, Type4, Type5, Type6>(this IEnumerable<Type1> type1Values, IEnumerable<Type2> type2Values, IEnumerable<Type3> type3Values, IEnumerable<Type4> type4Values, IEnumerable<Type5> type5Values, IEnumerable<Type6> type6Values)
		{
			foreach (var type1Value in type1Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type1Value);
			}
			foreach (var type2Value in type2Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type2Value);
			}
			foreach (var type3Value in type3Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type3Value);
			}
			foreach (var type4Value in type4Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type4Value);
			}
			foreach (var type5Value in type5Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type5Value);
			}
			foreach (var type6Value in type6Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>(type6Value);
			}
		}
		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="Action5">Action to run for Type5</param>
		/// <param name="Action6">Action to run for Type6</param>
		/// <param name="Action7">Action to run for Type7</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<TUnion,Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this IEnumerable<TUnion> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7)
		where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item),
				type5Item => Action5(type5Item),
				type6Item => Action6(type6Item),
				type7Item => Action7(type7Item));
			}
		}

				/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="Function5">Function to run for Type5</param>
		/// <param name="Function6">Function to run for Type6</param>
		/// <param name="Function7">Function to run for Type7</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<TUnion,Type1, Type2, Type3, Type4, Type5, Type6, Type7, ReturnType>(this IEnumerable<TUnion> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7)
			where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item),
				type5Item => Function5(type5Item),
				type6Item => Function6(type6Item),
				type7Item => Function7(type7Item));
			}
		}

		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="Action5">Action to run for Type5</param>
		/// <param name="Action6">Action to run for Type6</param>
		/// <param name="Action7">Action to run for Type7</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7)
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item),
				type5Item => Action5(type5Item),
				type6Item => Action6(type6Item),
				type7Item => Action7(type7Item));
			}
		}

		/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="Function5">Function to run for Type5</param>
		/// <param name="Function6">Function to run for Type6</param>
		/// <param name="Function7">Function to run for Type7</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, ReturnType>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7)
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item),
				type5Item => Function5(type5Item),
				type6Item => Function6(type6Item),
				type7Item => Function7(type7Item));
			}
		}

		/// <summary>
		/// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="item"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> MergeItem<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values, Type8 item)
		{
			return values.Merge((IEnumerable<Type8>)new List<Type8>{ item });
		}

		/// <summary>
		/// Merges the item intos the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the items as a new option.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="items"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values, IEnumerable<Type8> items)
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
			foreach (var item in items)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(item);
			}
		}

				/// <summary>
		/// Merges to given collections into a discriminated union collection.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
		/// <param name="type1Values">a collection to merge</param>
		/// <param name="type2Values">a collection to merge</param>
		/// <param name="type3Values">a collection to merge</param>
		/// <param name="type4Values">a collection to merge</param>
		/// <param name="type5Values">a collection to merge</param>
		/// <param name="type6Values">a collection to merge</param>
		/// <param name="type7Values">a collection to merge</param>
		/// <returns>Discriminated unions of all types.</returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this IEnumerable<Type1> type1Values, IEnumerable<Type2> type2Values, IEnumerable<Type3> type3Values, IEnumerable<Type4> type4Values, IEnumerable<Type5> type5Values, IEnumerable<Type6> type6Values, IEnumerable<Type7> type7Values)
		{
			foreach (var type1Value in type1Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type1Value);
			}
			foreach (var type2Value in type2Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type2Value);
			}
			foreach (var type3Value in type3Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type3Value);
			}
			foreach (var type4Value in type4Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type4Value);
			}
			foreach (var type5Value in type5Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type5Value);
			}
			foreach (var type6Value in type6Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type6Value);
			}
			foreach (var type7Value in type7Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(type7Value);
			}
		}
		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="Action5">Action to run for Type5</param>
		/// <param name="Action6">Action to run for Type6</param>
		/// <param name="Action7">Action to run for Type7</param>
		/// <param name="Action8">Action to run for Type8</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<TUnion,Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this IEnumerable<TUnion> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8)
		where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item),
				type5Item => Action5(type5Item),
				type6Item => Action6(type6Item),
				type7Item => Action7(type7Item),
				type8Item => Action8(type8Item));
			}
		}

				/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="Function5">Function to run for Type5</param>
		/// <param name="Function6">Function to run for Type6</param>
		/// <param name="Function7">Function to run for Type7</param>
		/// <param name="Function8">Function to run for Type8</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<TUnion,Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, ReturnType>(this IEnumerable<TUnion> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8)
			where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item),
				type5Item => Function5(type5Item),
				type6Item => Function6(type6Item),
				type7Item => Function7(type7Item),
				type8Item => Function8(type8Item));
			}
		}

		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="Action5">Action to run for Type5</param>
		/// <param name="Action6">Action to run for Type6</param>
		/// <param name="Action7">Action to run for Type7</param>
		/// <param name="Action8">Action to run for Type8</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8)
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item),
				type5Item => Action5(type5Item),
				type6Item => Action6(type6Item),
				type7Item => Action7(type7Item),
				type8Item => Action8(type8Item));
			}
		}

		/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="Function5">Function to run for Type5</param>
		/// <param name="Function6">Function to run for Type6</param>
		/// <param name="Function7">Function to run for Type7</param>
		/// <param name="Function8">Function to run for Type8</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, ReturnType>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8)
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item),
				type5Item => Function5(type5Item),
				type6Item => Function6(type6Item),
				type7Item => Function7(type7Item),
				type8Item => Function8(type8Item));
			}
		}

		/// <summary>
		/// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
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
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="item"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> MergeItem<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values, Type9 item)
		{
			return values.Merge((IEnumerable<Type9>)new List<Type9>{ item });
		}

		/// <summary>
		/// Merges the item intos the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the items as a new option.
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
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="items"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values, IEnumerable<Type9> items)
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
			foreach (var item in items)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(item);
			}
		}

				/// <summary>
		/// Merges to given collections into a discriminated union collection.
		/// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
		/// <param name="type1Values">a collection to merge</param>
		/// <param name="type2Values">a collection to merge</param>
		/// <param name="type3Values">a collection to merge</param>
		/// <param name="type4Values">a collection to merge</param>
		/// <param name="type5Values">a collection to merge</param>
		/// <param name="type6Values">a collection to merge</param>
		/// <param name="type7Values">a collection to merge</param>
		/// <param name="type8Values">a collection to merge</param>
		/// <returns>Discriminated unions of all types.</returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this IEnumerable<Type1> type1Values, IEnumerable<Type2> type2Values, IEnumerable<Type3> type3Values, IEnumerable<Type4> type4Values, IEnumerable<Type5> type5Values, IEnumerable<Type6> type6Values, IEnumerable<Type7> type7Values, IEnumerable<Type8> type8Values)
		{
			foreach (var type1Value in type1Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type1Value);
			}
			foreach (var type2Value in type2Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type2Value);
			}
			foreach (var type3Value in type3Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type3Value);
			}
			foreach (var type4Value in type4Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type4Value);
			}
			foreach (var type5Value in type5Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type5Value);
			}
			foreach (var type6Value in type6Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type6Value);
			}
			foreach (var type7Value in type7Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type7Value);
			}
			foreach (var type8Value in type8Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(type8Value);
			}
		}
		/// <summary>
		/// Matches the specific types and executes the given action for them.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
        /// <typeparam name="Type9">Type9</typeparam>
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="Action5">Action to run for Type5</param>
		/// <param name="Action6">Action to run for Type6</param>
		/// <param name="Action7">Action to run for Type7</param>
		/// <param name="Action8">Action to run for Type8</param>
		/// <param name="Action9">Action to run for Type9</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<TUnion,Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this IEnumerable<TUnion> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8, Action<Type9> Action9)
		where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item),
				type5Item => Action5(type5Item),
				type6Item => Action6(type6Item),
				type7Item => Action7(type7Item),
				type8Item => Action8(type8Item),
				type9Item => Action9(type9Item));
			}
		}

				/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
		/// </summary>
		/// <typeparam name="TUnion">TUnion</typeparam>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <typeparam name="Type5">Type5</typeparam>
        /// <typeparam name="Type6">Type6</typeparam>
        /// <typeparam name="Type7">Type7</typeparam>
        /// <typeparam name="Type8">Type8</typeparam>
        /// <typeparam name="Type9">Type9</typeparam>
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="Function5">Function to run for Type5</param>
		/// <param name="Function6">Function to run for Type6</param>
		/// <param name="Function7">Function to run for Type7</param>
		/// <param name="Function8">Function to run for Type8</param>
		/// <param name="Function9">Function to run for Type9</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<TUnion,Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, ReturnType>(this IEnumerable<TUnion> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8, Func<Type9, ReturnType> Function9)
			where TUnion : DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item),
				type5Item => Function5(type5Item),
				type6Item => Function6(type6Item),
				type7Item => Function7(type7Item),
				type8Item => Function8(type8Item),
				type9Item => Function9(type9Item));
			}
		}

		/// <summary>
		/// Matches the specific types and executes the given action for them.
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
		/// <param name="Action1">Action to run for Type1</param>
		/// <param name="Action2">Action to run for Type2</param>
		/// <param name="Action3">Action to run for Type3</param>
		/// <param name="Action4">Action to run for Type4</param>
		/// <param name="Action5">Action to run for Type5</param>
		/// <param name="Action6">Action to run for Type6</param>
		/// <param name="Action7">Action to run for Type7</param>
		/// <param name="Action8">Action to run for Type8</param>
		/// <param name="Action9">Action to run for Type9</param>
		/// <param name="values">existing Discriminated unions</param>
		public static void Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values,  Action<Type1> Action1, Action<Type2> Action2, Action<Type3> Action3, Action<Type4> Action4, Action<Type5> Action5, Action<Type6> Action6, Action<Type7> Action7, Action<Type8> Action8, Action<Type9> Action9)
		{
			foreach(var item in values)
			{
				item.Match(
				type1Item => Action1(type1Item),
				type2Item => Action2(type2Item),
				type3Item => Action3(type3Item),
				type4Item => Action4(type4Item),
				type5Item => Action5(type5Item),
				type6Item => Action6(type6Item),
				type7Item => Action7(type7Item),
				type8Item => Action8(type8Item),
				type9Item => Action9(type9Item));
			}
		}

		/// <summary>
		/// Matches the specific types and uses the given functions to tranform into s ingle returntype.
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
		/// <typeparam name="ReturnType">the returntype for all functions</typeparam>
		/// <param name="Function1">Function to run for Type1</param>
		/// <param name="Function2">Function to run for Type2</param>
		/// <param name="Function3">Function to run for Type3</param>
		/// <param name="Function4">Function to run for Type4</param>
		/// <param name="Function5">Function to run for Type5</param>
		/// <param name="Function6">Function to run for Type6</param>
		/// <param name="Function7">Function to run for Type7</param>
		/// <param name="Function8">Function to run for Type8</param>
		/// <param name="Function9">Function to run for Type9</param>
		/// <param name="values">existing Discriminated unions</param>
		public static IEnumerable<ReturnType> Match<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, ReturnType>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values,Func<Type1, ReturnType> Function1, Func<Type2, ReturnType> Function2, Func<Type3, ReturnType> Function3, Func<Type4, ReturnType> Function4, Func<Type5, ReturnType> Function5, Func<Type6, ReturnType> Function6, Func<Type7, ReturnType> Function7, Func<Type8, ReturnType> Function8, Func<Type9, ReturnType> Function9)
		{
			foreach(var item in values)
			{
				yield return item.Match(
								type1Item => Function1(type1Item),
				type2Item => Function2(type2Item),
				type3Item => Function3(type3Item),
				type4Item => Function4(type4Item),
				type5Item => Function5(type5Item),
				type6Item => Function6(type6Item),
				type7Item => Function7(type7Item),
				type8Item => Function8(type8Item),
				type9Item => Function9(type9Item));
			}
		}

		/// <summary>
		/// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
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
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="item"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> MergeItem<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values, Type10 item)
		{
			return values.Merge((IEnumerable<Type10>)new List<Type10>{ item });
		}

		/// <summary>
		/// Merges the item intos the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the items as a new option.
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
		/// <param name="values">existing Discriminated unions</param>
		/// <param name="items"></param>
		/// <returns></returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values, IEnumerable<Type10> items)
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
			foreach (var item in items)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(item);
			}
		}

				/// <summary>
		/// Merges to given collections into a discriminated union collection.
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
		/// <param name="type1Values">a collection to merge</param>
		/// <param name="type2Values">a collection to merge</param>
		/// <param name="type3Values">a collection to merge</param>
		/// <param name="type4Values">a collection to merge</param>
		/// <param name="type5Values">a collection to merge</param>
		/// <param name="type6Values">a collection to merge</param>
		/// <param name="type7Values">a collection to merge</param>
		/// <param name="type8Values">a collection to merge</param>
		/// <param name="type9Values">a collection to merge</param>
		/// <returns>Discriminated unions of all types.</returns>
		public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this IEnumerable<Type1> type1Values, IEnumerable<Type2> type2Values, IEnumerable<Type3> type3Values, IEnumerable<Type4> type4Values, IEnumerable<Type5> type5Values, IEnumerable<Type6> type6Values, IEnumerable<Type7> type7Values, IEnumerable<Type8> type8Values, IEnumerable<Type9> type9Values)
		{
			foreach (var type1Value in type1Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type1Value);
			}
			foreach (var type2Value in type2Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type2Value);
			}
			foreach (var type3Value in type3Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type3Value);
			}
			foreach (var type4Value in type4Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type4Value);
			}
			foreach (var type5Value in type5Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type5Value);
			}
			foreach (var type6Value in type6Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type6Value);
			}
			foreach (var type7Value in type7Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type7Value);
			}
			foreach (var type8Value in type8Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type8Value);
			}
			foreach (var type9Value in type9Values)
			{
				yield return new DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(type9Value);
			}
		}
	}
}


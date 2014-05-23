





namespace DiscriminatedUnions
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
        /// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <param name="values">existing Discriminated unions</param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> Merge<Type1, Type2, Type3>(this IEnumerable<DiscriminatedUnion<Type1, Type2>> values, Type3 item)
        {
			return values.Merge((IEnumerable<Type3>)new List<Type3>{ item });
		}

		/// <summary>
        /// Merges the item intos the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the items as a new option.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
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
        /// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <param name="values">existing Discriminated unions</param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> Merge<Type1, Type2, Type3, Type4>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3>> values, Type4 item)
        {
			return values.Merge((IEnumerable<Type4>)new List<Type4>{ item });
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
        /// Merges the item into the existing discriminatedunions resulting in a new enumerable of discriminated unions with the type of the item as a new option.
        /// </summary>
        /// <typeparam name="Type1">Type1</typeparam>
        /// <typeparam name="Type2">Type2</typeparam>
        /// <typeparam name="Type3">Type3</typeparam>
        /// <typeparam name="Type4">Type4</typeparam>
        /// <param name="values">existing Discriminated unions</param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> Merge<Type1, Type2, Type3, Type4, Type5>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4>> values, Type5 item)
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
        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> Merge<Type1, Type2, Type3, Type4, Type5, Type6>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5>> values, Type6 item)
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
        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6>> values, Type7 item)
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
        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7>> values, Type8 item)
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
        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8>> values, Type9 item)
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
        public static IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>> Merge<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9, Type10>(this IEnumerable<DiscriminatedUnion<Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Type9>> values, Type10 item)
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


    }
}

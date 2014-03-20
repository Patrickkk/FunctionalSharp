namespace DiscriminatedUnions
{
	using System;
    using System.Collections.Generic;
    public static class DiscriminatedUnionExtensions
    {
        public static IEnumerable<DiscriminatedUnion<Type1, Type2>> DiscriminatedUnion<Type1, Type2>(this IEnumerable<Type1> original, params IEnumerable<IEnumerable<Type2>> listsToMerge)
        {
            var result = new DiscriminatedUnionList<Type1, Type2>();
            foreach (var item in original)
            {
                result.Add(item);
            }

            foreach (var listToMerge in listsToMerge)
            {
                foreach (var item in listToMerge)
                {
                    result.Add(item);
                }

            }
            return result;
        }
    }

}

using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.LinqExtensions
{
    public static class GroupExtensions
    {
        public static IEnumerable<IGrouping<int, T>> GroupPer<T>(this IEnumerable<T> collection, int groupSize)
        {
            return collection.Select((s, i) => new { Value = s, Index = i })
                .GroupBy(item => item.Index / groupSize, item => item.Value);//TODO Unit test
        }
    }
}

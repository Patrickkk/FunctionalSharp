using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace FunctionalSharp.PatternMatching
{
    public static class ReadOnlyCollectionExtensions
    {
        public static ReadOnlyCollection<T> Add<T>(this ReadOnlyCollection<T> collection, T item)
        {
            var list = new List<T>(collection);
            list.Add(item);
            return new ReadOnlyCollection<T>(list);
        }
    }
}
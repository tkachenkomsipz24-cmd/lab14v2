using System;
using System.Collections.Generic;

namespace lab14v2
{
    public static class CollectionHelper<T>
    {
        public static IEnumerable<TResult> Map<TResult>(IEnumerable<T> collection, Func<T, TResult> mapper)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            if (mapper == null)
                throw new ArgumentNullException(nameof(mapper));

            List<TResult> result = new List<TResult>();

            foreach (T item in collection)
            {
                result.Add(mapper(item));
            }

            return result;
        }
    }
}
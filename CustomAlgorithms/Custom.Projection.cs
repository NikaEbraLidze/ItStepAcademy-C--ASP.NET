namespace Custom.Projection
{
    public static class CustomProjection
    {
        // Select, SelectMany, Range, Empty
        #region Select
        public static IEnumerable<T> Select<TSource, T>(
            this IEnumerable<TSource> source,
            Func<TSource, T> selector
        )
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (selector == null)
            {
                throw new ArgumentNullException("selector");
            }

            return SelectImpl(source, selector);
        }

        private static IEnumerable<TResult> SelectImpl<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, TResult> selector
        )
        {
            foreach (TSource item in source)
            {
                yield return selector(item);
            }
        }
        public static IEnumerable<T> Select<TSource, T>(
            this IEnumerable<TSource> source,
            Func<TSource, int, T> selector
        )
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (selector == null)
            {
                throw new ArgumentNullException("selector");
            }

            return SelectImpl(source, selector);
        }
        private static IEnumerable<TResult> SelectImpl<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<TSource, int, TResult> selector
        )
        {
            int index = 0;
            foreach (TSource item in source)
            {
                yield return selector(item, index);
                index++;
            }
        }
        #endregion

        #region Range
        public static IEnumerable<int> Range(int start, int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count");
            }
            if (start + count - 1L > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException("count");
            }

            return RangeImp(start, count);
        }

        private static IEnumerable<int> RangeImp(int start, int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return start + i;
            }
        }
        #endregion
    }
}
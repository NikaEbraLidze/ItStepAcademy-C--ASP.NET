using System.Diagnostics;

namespace Custom.Filtering
{
    public static class CustomFiltering
    {
        #region Where
        public static IEnumerable<T> Where<T>(
            this IEnumerable<T> source,
            Func<T, bool> predicate
        )
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            return WhereImpl(source, predicate);
        }
        private static IEnumerable<T> WhereImpl<T>(
            this IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Where<T>(
            this IEnumerable<T> source,
            Func<T, int, bool> predicate
        )
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            return WhereImpl(source, predicate);
        }
        private static IEnumerable<T> WhereImpl<T>(
            this IEnumerable<T> source,
            Func<T, int, bool> predicate)
        {
            int index = 0;

            foreach (T item in source)
            {
                if (predicate(item, index))
                {
                    yield return item;
                }
            }
        }
        #endregion

        #region Any and All
        public static bool Any<T>(
            this IEnumerable<T> source
        )
        {
            if (source == null)
                throw new ArgumentNullException("source");

            foreach (T item in source)
                return true;

            return false;
        }

        public static bool Any<T>(
            this IEnumerable<T> source,
            Func<T, bool> predicate
        )
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            return AnyImp(source, predicate);
        }

        private static bool AnyImp<T>(
            IEnumerable<T> source,
            Func<T, bool> predicate
        )
        {
            foreach (T item in source)
            {
                if (predicate(item))
                    return true;
            }

            return false;
        }

        public static bool All<T>(
            this IEnumerable<T> source,
            Func<T, bool> predicate
        )
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            return AllImp(source, predicate);
        }

        private static bool AllImp<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T item in source)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region  First, Single, Last and the …OrDefault versions
        public static T First<T>(
            this IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            using (IEnumerator<T> iterator = source.GetEnumerator())
            {
                if (iterator.MoveNext())
                {
                    return iterator.Current;
                }
                throw new InvalidOperationException("Sequence was empty");
            }
        }

        public static T First<T>(
            this IEnumerable<T> source,
            Func<T, bool> predicate
        )
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            foreach (T item in source)
                if (predicate(item))
                    return item;

            throw new InvalidOperationException("No element found.");
        }

        public static T? FirstOrDefault<T>(
            this IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            using (IEnumerator<T> iterator = source.GetEnumerator())
            {
                return iterator.MoveNext() ? iterator.Current : default;
            }
        }

        public static T? FirstOrDefault<T>(
            this IEnumerable<T> source,
            Func<T, bool> predicate
        )
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            foreach (T item in source)
            {
                if (predicate(item))
                    return item;
            }

            return default;
        }

        public static TSource Single<TSource>(
            this IEnumerable<TSource> source
        )
        {
            using (IEnumerator<TSource> iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext())
                {
                    throw new InvalidOperationException("Sequence was empty");
                }
                TSource ret = iterator.Current;
                if (iterator.MoveNext())
                {
                    throw new InvalidOperationException("Sequence contained multiple elements");
                }
                return ret;
            }
        }

        public static TSource Single<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate
        )
        {
            TSource? ret = default;
            bool foundAny = false;
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    if (foundAny)
                    {
                        throw new InvalidOperationException("Sequence contained multiple matching elements");
                    }
                    foundAny = true;
                    ret = item;
                }
            }
            if (!foundAny)
            {
                throw new InvalidOperationException("No items matched the predicate");
            }
            return ret;
        }
        #endregion

        #region  Take, Skip, TakeWhile, SkipWhile
        public static IEnumerable<T> Take<T>(
            this IEnumerable<T> source,
            int count
        )
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (count <= 0)
                yield break;

            using (IEnumerator<T> e = source.GetEnumerator())
            {
                for (int i = 0; i < count && e.MoveNext(); i++)
                {
                    yield return e.Current;
                }
            }
        }

        public static IEnumerable<T> Skip<T>(
            this IEnumerable<T> source,
            int count
        )
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (count <= 0)
            {
                foreach (var item in source)
                    yield return item;
                yield break;
            }

            using (IEnumerator<T> e = source.GetEnumerator())
            {
                int i;
                for (i = 0; i < count; i++)
                {
                    if (!e.MoveNext())
                        yield break;
                }
                while (e.MoveNext())
                {
                    yield return e.Current;
                }
            }
        }

        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            foreach (T item in source)
            {
                if (!predicate(item))
                    yield break;
                yield return item;
            }
        }

        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> source, Func<T, int, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            int index = 0;
            foreach (T item in source)
            {
                if (!predicate(item, index))
                    yield break;
                yield return item;
                index++;
            }
        }

        public static IEnumerable<T> SkipWhile<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            using (IEnumerator<T> e = source.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    T item = e.Current;
                    if (!predicate(item))
                    {
                        yield return item;
                        break;
                    }
                }
                while (e.MoveNext())
                {
                    yield return e.Current;
                }

            }
        }

        public static IEnumerable<T> SkipWhile<T>(this IEnumerable<T> source, Func<T, int, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (predicate == null)
                throw new ArgumentNullException("predicate");

            int index = 0;
            using (IEnumerator<T> e = source.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    T item = e.Current;
                    if (!predicate(item, index))
                    {
                        yield return item;
                        break;
                    }
                    index++;
                }
                while (e.MoveNext())
                {
                    yield return e.Current;
                }

            }
        }
        #endregion
    }
}
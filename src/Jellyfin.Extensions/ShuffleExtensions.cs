using System;
using System.Collections.Generic;
using System.Linq;

namespace Jellyfin.Extensions
{
    /// <summary>
    /// Provides <c>Shuffle</c> extensions methods for <see cref="IList{T}" />.
    /// </summary>
    public static class ShuffleExtensions
    {
        /// <summary>
        /// Shuffles the items in a list.
        /// </summary>
        /// <param name="list">The list that should get shuffled.</param>
        /// <typeparam name="T">The type.</typeparam>
        public static void Shuffle<T>(this IList<T> list)
        {
            list.Shuffle(Random.Shared);
        }

        /// <summary>
        /// Shuffles the items in a list.
        /// </summary>
        /// <param name="list">The list that should get shuffled.</param>
        /// <param name="rng">The random number generator to use.</param>
        /// <typeparam name="T">The type.</typeparam>
        public static void Shuffle<T>(this IList<T> list, Random rng)
        {
            var randomList = list.OrderBy(x => rng.Next()).Take(150);

            foreach(T tNode in randomList)
            {
                T value = tNode;
            }
        }
    }
}

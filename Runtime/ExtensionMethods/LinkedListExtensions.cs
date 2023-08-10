using System;
using System.Collections.Generic;

namespace NovaDawnStudios.NovaUtils
{
    /// <summary>
    ///     Provides extension methods for the <see cref="LinkedList{T}"/> DotNet type.
    /// </summary>
    public static class LinkedListExtensions
    {
        /// <summary>
        ///     Removes all entries from the given <paramref name="list"/> that fail the given <paramref name="predicate"/>.
        /// </summary>
        /// <typeparam name="T">The type of the linked list.</typeparam>
        /// <param name="list">The list we're removing values from.</param>
        /// <param name="predicate">The function to evaluate against each entry in <paramref name="list"/> to determine if it should be removed or not.</param>
        /// <returns>The number of entries that were removed.</returns>
        public static int RemoveAll<T>(this LinkedList<T> list, Predicate<T> predicate)
        {
            var toRemove = new List<LinkedListNode<T>>(list.Count);

            var node = list.First;
            while (node != null)
            {
                if (predicate(node.Value))
                {
                    toRemove.Add(node);
                }

                node = node.Next;
            }

            foreach (var n in toRemove)
            {
                list.Remove(n);
            }

            return toRemove.Count;
        }
    }
}
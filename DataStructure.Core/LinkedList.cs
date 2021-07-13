using DataStructure.Model;
using System;

namespace DataStructure.Core
{
    /// <summary>
    /// Creates the linkage for the nodes of the linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>
    {
        private Node<T> Head;
        private Node<T> Tail;
        private int Size;

        /// <summary>
        /// Starts out with its data set as null until an item is added to it
        /// </summary>
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        /// <summary>
        /// returns the number of items in the list.
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return Size;
        }

        /// <summary>
        /// checks if the list is empty and returns either true or false
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Size == 0;
        }

        /// <summary>
        /// Adds item to the linked list and returns the current size of the list.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Add(T item)
        {
            var newest = new Node<T>(item, null);
            if (IsEmpty())
                Head = newest;
            else
            {
                Tail.Next = newest;
            }
            Tail = newest;
            Size++;
            return Size;
        }
    }
}

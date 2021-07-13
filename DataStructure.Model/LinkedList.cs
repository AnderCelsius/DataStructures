using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Base
{
    /// <summary>
    /// Creates the linkage for the nodes of the linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> where T : IComparable
    {
        public Node<T> Head;
        public Node<T> Tail;
        public int Size;

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
        /// Inserts a new Node at the end of the list and returns the current size of the list.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Add(T item)
        {
            var newNode = new Node<T>(item);
            if (IsEmpty())
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }
            Tail = newNode;
            Size++;
            return Size;
        }

        /// <summary>
        /// Searches through the linked list starting from the head to get the first occurence of the item. 
        /// If the item is found, removes it and returns true but if item is not found, it returns false.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            Node<T> current = new Node<T>(item);

            if(Check(item))
                current.Next = current.Next.Next;
            return Check(item);
        }

        /// <summary>
        /// Checks for a specified item in the linked list. Returns true if found and false if not found. 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Check(T item)
        {
            Node<T> current = new Node<T>(item);

            while (current.Data.CompareTo(item) != 0)
            {
                current = current.Next;
            }
            return current.Next.Data != null;
        }

        /// <summary>
        /// Returns the index of an item or returns -1 if the item is not found 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Index(T item)
        {
            Node<T> current = new Node<T>(item);
            int index = 0;

            while(Check(item) != false)
            {
                current = current.Next;
                index++;
            }
            
            return index;

        }

    }
}

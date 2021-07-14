using System;

namespace SinglyLinkedList
{
    /// <summary>
    /// Holds the data value and the pointer which points to the location of the next node in the linked list. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T> 
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }

    }
}

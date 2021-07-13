using System;

namespace DataStructure.Base
{
    public class Node<T> where T : IComparable
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

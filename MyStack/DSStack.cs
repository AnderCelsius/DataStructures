using DataStructure.Base;
using System;

namespace MyStack
{
    public class DSStack<T> where T : IComparable
    {
        LinkedList<T> myStack = new LinkedList<T>(); // Create a new instance of Linked list to apply the stack concept.

        /// <summary>
        /// Adds an item to the tail of the stack 
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            myStack.Add(item);
        }

        /// <summary>
        /// Removes and returns the last item added to the stack 
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            Node<T> node = myStack.Head;

            if (myStack.IsEmpty())
                throw new Exception("There is no item in the Stack");
            else if(node == myStack.Tail)
            {
                T temp = node.Data;
                myStack.Head = null;
                myStack.Tail = null;
                return temp;
            }
            else
            {
                while(node.Next != myStack.Tail)
                {
                    node = node.Next;
                }
                T temp = myStack.Tail.Data;
                myStack.Tail = node;
                return temp;
            }
        }

        /// <summary>
        /// Returns the last item added to the stack 
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            Node<T> node = myStack.Head;

            if (myStack.IsEmpty())
                throw new Exception("There is no item in the Stack");
            else if (node == myStack.Tail)
            {
                return node.Data;
            }
            else
            {
                while (node.Next != myStack.Tail)
                {
                    node = node.Next;
                }
                return myStack.Tail.Data;
            }
        }

        /// <summary>
        /// Returns the number of items currently in the stack 
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return myStack.Length();
        }
    }
}

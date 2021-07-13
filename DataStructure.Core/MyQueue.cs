using DataStructure.Base;
using System;

namespace MyQueue
{
    public class MyQueue<T> 
    {
        LinkedList<T> myQueue = new LinkedList<T>();

        /// <summary>
        /// Adds an item to the tail of the queue 
        /// </summary>
        /// <param name="item"></param>
        public void EnQueue(T item)
        {
            myQueue.Add(item);
        }

        /// <summary>
        /// Removes and returns the first item added to the queue 
        /// </summary>
        /// <returns></returns>
        public T DeQueue()
        {
            if (myQueue.IsEmpty())
                throw new Exception("There is no item in the Stack");

            Node<T> node = myQueue.Head;
            myQueue.Head = node.Next;
            myQueue.Size--;
            return node.Data;
        }

        
        /// <summary>
        /// Returns the number of items currently in the stack 
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return myQueue.Length();
        }

    }
    
}

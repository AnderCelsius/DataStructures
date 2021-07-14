using MyStack;
using MyQueue;
using System;
using SinglyLinkedList;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackNum = new MyStack<int>();
            //stackNum.Push(5);
            //stackNum.Push(10);
            //stackNum.Push(15);
            //Console.WriteLine(stackNum.Peek());
            //Console.WriteLine(stackNum.Size());
            //Console.WriteLine(stackNum.Pop());
            //Console.WriteLine(stackNum.Size());
            //Console.WriteLine(stackNum.Pop());
            //Console.WriteLine(stackNum.Size());
            //Console.WriteLine(stackNum.Pop());
            //Console.WriteLine(stackNum.Size());
            //Console.WriteLine(stackNum.IsEmpty());

            var queueNum = new MyQueue<int>();
            //queueNum.EnQueue(5);
            //queueNum.EnQueue(10);
            //Console.WriteLine(queueNum.Size());
            //Console.WriteLine(queueNum.DeQueue());
            //Console.WriteLine(queueNum.Size());
            //Console.WriteLine(queueNum.DeQueue());
            //Console.WriteLine(queueNum.Size());
            //Console.WriteLine(queueNum.DeQueue());

            var linkList = new LinkedList<int>();
            linkList.Add(5);
            linkList.Add(10);
            linkList.Add(15);
            linkList.Add(10);
            //Console.WriteLine(linkList.Index(7));
            //Console.WriteLine(linkList.Check(7)); 

            //foreach (var item in linkList)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(linkList.Size);
            Console.WriteLine(linkList.Remove(59));
            Console.WriteLine(linkList.Size);
        }
    }
}

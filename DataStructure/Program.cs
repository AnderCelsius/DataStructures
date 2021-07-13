using MyStack;
using MyQueue;
using System;

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
            queueNum.EnQueue(5);
            queueNum.EnQueue(10);
            Console.WriteLine(queueNum.Size());
            Console.WriteLine(queueNum.DeQueue());
            Console.WriteLine(queueNum.Size());
            Console.WriteLine(queueNum.DeQueue());
            Console.WriteLine(queueNum.Size());
            Console.WriteLine(queueNum.DeQueue());
        }
    }
}

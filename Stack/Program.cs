using System;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = new Stack<int>();

            name.Push(10);
            name.Push(20);
            name.Push(30);
            name.Push(30);

            foreach (var i in name)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("After Pop");
            name.Pop();
            Console.WriteLine(name.Peek());


            //Queue(opposit of stack)

            //Queue declaration//

            Queue <int> MyQueue = new Queue<int>();
            MyQueue.Enqueue(10);
            MyQueue.Enqueue(20);
            MyQueue.Enqueue(30);
            MyQueue.Enqueue(40);

            Console.WriteLine(" Numbers of Element = "+MyQueue.Count);
            foreach (var item in MyQueue)
            {
                Console.WriteLine(item);
            }
                
                
                


        }
    }
}
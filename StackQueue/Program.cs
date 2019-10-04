using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> stackQueue = new StackQueue<int>();

            stackQueue.AddBack(4);
            stackQueue.AddBack(8);
            stackQueue.AddBack(16);
            stackQueue.AddBack(32);

            Console.WriteLine(stackQueue.RemoveFront());
        }
    }
}

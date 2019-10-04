using System;
namespace StackQueue
{
    public interface IQueue<T>
    {
        T RemoveFront();
        void AddBack(T item);
        T Peek();
        bool IsEmpty { get; }
        int Size { get; }
        string ToString();
    }
}

using System;
namespace StackQueue
{
    public interface IStack<T>
    {
        T Pop();
        void Push(T item);
        T Peek();
        bool IsEmpty { get; }
        int Size { get; }
        string ToString();
    }
}

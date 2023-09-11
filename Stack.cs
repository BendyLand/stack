using System;

namespace Stack
{
    class Stack
    {
        public Node<T> TopItem
        { get; private set; }
        public int Size
        { get; private set; }
        public int Limit
        { get; }

        public Stack(int limit = 1000)
        {
            TopItem = null;
            Size = 0;
            Limit = limit
        }
    }
}
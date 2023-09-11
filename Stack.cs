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

        public void Push(T value)
        {
            if self.HasSpace()
            {
                Node<T> item = new Node<T>(value);
                item.NextNode = TopItem;
                TopItem = item;
                Size++;
                Console.WriteLine($"Adding {value} to the pizza stack!");
            }
            else
            {
                Console.WriteLine($"No room for {value} in stack.");
            }
        }

        public T Pop()
        {
            if not self.IsEmpty()
            {
                Node<T> itemToRemove = TopItem;
                TopItem = itemToRemove.NextNode;
                Size--;
                Console.WriteLine($"Delivering{itemToRemove.Value}");
                return itemToRemove.Value;
            }
            Console.WriteLine("All out of pizza");
            return default;
        }

        public T Peek()
        {
            if not self.IsEmpty()
            {
                return TopItem.Value;
            }
            Console.WriteLine("Nothing to see here!");
            return default;
        }

        public bool HasSpace()
        {
            return Limit > Size;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }
    }
}
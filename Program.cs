using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> lst = new Stack<string>();
            lst.Push("Ben");
            lst.Push("Olivia");
            lst.Push("Reese");
            lst.Push("Puff");

            Console.WriteLine(lst.Peek());
            
            lst.Pop();

            Console.WriteLine(lst.Peek());
        }
    }
}
using System;

namespace StackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node node = new Node(1);
            Stack stack = new Stack();

            stack.push(node);
            stack.printContents();
        }
    }
}

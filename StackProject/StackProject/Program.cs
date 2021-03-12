using System;

namespace StackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Stack stack = new Stack();

            stack.push(new Node(1));
            stack.push(new Node(2));
            stack.push(new Node(3));
            stack.push(new Node(4));
            stack.push(new Node(5));
            stack.push(new Node(6));
            stack.printContents();

            int last = stack.pop();
            Console.WriteLine("Pop Element " +last);
            int top = stack.top();
            Console.WriteLine("Top Element " + top);

            Node node = new Node(7);
            stack.push(node);
            int newElement = stack.top();
            Console.WriteLine("Added New Element " + newElement);

        }
    }
}

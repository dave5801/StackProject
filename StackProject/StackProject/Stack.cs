using System;
using System.Collections.Generic;
using System.Text;

namespace StackProject
{
    public class Stack
    {
        List<Node> theStack = new List<Node>();
        public Stack() { }

        public void push(Node newNode) 
        {
            theStack.Add(newNode);
        }

        public void pop() { }

        public void top() 
        {
            var p = theStack[theStack.Count - 1];
            theStack.RemoveAt(theStack.Count - 1);
        }

        public void printContents() 
        {
            foreach (var element in theStack) 
            {
                Console.WriteLine(element.getValue());
            }
        }
    }
}

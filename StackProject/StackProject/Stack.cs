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

        public int pop() 
        { 
            var p = theStack[theStack.Count - 1];
            theStack.RemoveAt(theStack.Count - 1);
            return p.getValue();
        }

        public int top() 
        {
            var p = theStack[theStack.Count - 1];
            
            return p.getValue();
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

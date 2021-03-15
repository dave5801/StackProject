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

            int p = 0;

            if (theStack.Count == 0) 
            {
                throw new StackNotInitializedException("Stack not initialized, push some element first");
            }

            
            p = theStack[theStack.Count - 1]._value;
            theStack.RemoveAt(theStack.Count - 1);

                        
            return p;
        }

        public int top() 
        {

            try
            {
                var p = theStack[theStack.Count - 1];

                return p._value;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new StackNotInitializedException("Argument out of range, Stack not initialized, push some element first");
            }
            finally 
            {
                Console.WriteLine("No exceptions were caught");
            }

        }

        public void printContents() 
        {
            foreach (var element in theStack) 
            {
                Console.WriteLine(element._value);
            }
        }
    }
}

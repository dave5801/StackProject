using System;
using System.Collections.Generic;
using System.Text;

namespace StackProject
{
    public class Node
    {
        public readonly int _value;
        public Node _next;

        public Node(int value, Node next = null) 
        {
            _value = value;
            _next = next;
        }


    }
}

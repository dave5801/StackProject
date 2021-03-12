using System;
using System.Collections.Generic;
using System.Text;

namespace StackProject
{
    public class Node
    {
        private readonly int _value;
        private Node _next;

        public Node(int value, Node next = null) 
        {
            _value = value;
            _next = next;
        }

        public int getValue() 
        {
            return _value;
        }

    }
}

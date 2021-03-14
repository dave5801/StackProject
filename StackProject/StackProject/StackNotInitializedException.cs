using System;
using System.Collections.Generic;
using System.Text;

namespace StackProject
{
    public class StackNotInitializedException : Exception
    {
        public readonly string Error_Message = "Stack has not be initialized";
        public StackNotInitializedException() { }

        public StackNotInitializedException(string message) : base(message){ }
    }
}

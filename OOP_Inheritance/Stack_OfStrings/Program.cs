using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack_OfStrings
{
    class StackOfString : Stack<string>
    {
        public bool IsEmpty()
        {
            return base.Count == 0;
        }
        public void AddRange(params string[] a)
        {
            foreach (var item in a)
            {
                base.Push(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new StackOfString();
            Console.WriteLine(stack.IsEmpty());
            stack.AddRange("eee", "fff", "Ggg");
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Count);
        }
    }
}

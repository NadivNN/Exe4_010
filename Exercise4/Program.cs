using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList_CSharp
{
    class Stacks
    {
        static readonly int MAX = 190;
        int top;
        int[] stack = new int[MAX];
        public Stacks()
        {
            top = 1;
        }
        bool empty()
        {
            return (top < 0);
        }
        public void push(int element)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                stack[++top] = element;
                return;
            }
        }
    }
}





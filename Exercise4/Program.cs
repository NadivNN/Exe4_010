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
        public void pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Element Delete: " + stack[top--]);
                return;
            }
        }
        public void display()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}





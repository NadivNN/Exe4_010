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
                Console.WriteLine("\nThe popped element is: " + stack[top--]);
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
        static void Main(string[] args)
        {
            Stacks s = new Stacks();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n****Stack Menu****\n");
                Console.WriteLine("1. Push. ");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == " " ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}





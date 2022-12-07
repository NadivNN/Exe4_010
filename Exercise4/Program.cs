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
        int nnn;
        int[] stack = new int[MAX];
        public Stacks()
        {
            nnn = -1;
        }
        bool empty()
        {
            return (nnn < 0);
        }
        public void push(int element)
        {
            if (nnn >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                stack[++nnn] = element;
                return;
            }
        }
        public void pop()
        {
            if (nnn < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("\nThe popped element is: " + stack[nnn--]);
                return;
            }
        }
        public void display()
        {
            if (nnn < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = nnn; i >= 0; i--)
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





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
            top = -1;
        }
    }
}





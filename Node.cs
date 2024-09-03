using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresEx
{
    public class Node
    {
        public int Value;
        public Node Next;

        public int GetValue() { return Value; }
        public Node GetNext() { return Next; }

        public void SetValue(int value) { Value = value; }
        public void SetNext(Node next) { Next = next; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}

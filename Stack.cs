using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresEx
{
    public class Stack
    {
        public Node Top;
        public int count;
        public Stack() { }
        public Stack(int data)
        {
            Top = new Node(data);
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (Top == null)
            {
                Top = newNode;
            }
            else
            {
                newNode.Next = Top;
                Top = newNode;
            }
            count++;
        }
        public void Pop()
        {
            if (Top == null)
            {
                return;
            }
            Top = Top.Next;
        }
        public int Peak()
        {
            Node node = Top;
            if (node == null)
            {
                return -1;
            }
            return node.GetValue();
        }
        public int Count()
        {
            return count;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataStructuresEx
{
    public class Queue
    {
        public Node Head;
        public Node Tail;
        public int count;
        public Queue() { }
        public Queue(Node head, Node tail)
        {
            Head = head;
            Tail = tail;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                count++;
                return;
            }

            Tail.Next = newNode;
            Tail = newNode;
            count++;
        }
        public void Dequeue()
        {
            if (Head == null)
            {
                return;
            }
            Head = Head.Next;
        }
        public int Peek()
        {
            if (Head == null)
            {
                return -1;
            }
            return Head.Value;
        }
        public int Count()
        {

            return count;
        }

    }
}

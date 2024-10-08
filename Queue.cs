﻿using System;
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
            if (IsEmpty())
            {
                return;
            }
            Head = Head.Next;
            count--;
        }
        public int Peek()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return Head.Value;
        }
        public int Count()
        {
            if (IsEmpty())
            {
                return - 1;
            }
            return count;
        }
        public bool IsEmpty()
        { 
            return Head == null; 
        }

    }
}

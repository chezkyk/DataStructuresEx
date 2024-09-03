﻿using DataStructuresEx;

public class LinkedList
{
    public Node Head;

    public LinkedList()
    {
    }

    public LinkedList(int data)
    {
        Head = new Node(data);
    }

    // O(n)
    public void Add(int val)
    {
        Node newNode = new Node(val);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    // O(n)
    public void Display()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write($" -> {current.GetValue()}");
            current = current.Next;
        }
        Console.WriteLine();
    }

    // O(n)
    public int Length()
    {
        int count = 0;
        Node current = Head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    // O(n)
    public void RemoveAllValues(int data)
    {
        while (Head != null && Head.GetValue() == data)
        {
            Head = Head.Next;
        }

        Node current = Head;
        while (current != null && current.Next != null)
        {
            if (current.Next.GetValue() == data)
            {
                current.Next = current.Next.Next;
            }
            else
            {
                current = current.Next;
            }
        }
    }

    public void RemoveIndex(int index)
    {
        if (index < 0 || Head == null)
        {

            return;
        }

        if (index == 0)
        {
            Head = Head.Next;
            return;
        }

        Node current = Head;
        for (int i = 0; current != null && i < index - 1; i++)
        {
            current = current.Next;
        }

        if (current == null || current.Next == null)
        {

            return;
        }

        current.Next = current.Next.Next;
    }
    public int Find(int data)
    {
        int index = 0;
        Node current = Head;
        while (current != null)
        {
            if (current.GetValue() == data)
            {
                return index;
            }
            index++;
            current = current.Next;
        }
        return -1;
    }

    public int Get(int index)
    {
        if (index < 0)
        {

            return -1;
        }


        Node current = Head;
        for (int i = 0; current != null && i < index; i++)
        {
            current = current.Next;
        }

        if (current != null)
        {

            return current.GetValue();
        }

        return -1;
    }
}

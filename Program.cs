using DataStructuresEx;
using System;

class Program
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Display();
        var listLength = list.Length();
        Console.WriteLine($"listLength is: {listLength}");
    }
}
using _LinkedList;
using DataStructures;
using DoublyLinkedList;
using System;

namespace CompileFile
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>() { 1, 2, 3, 4, 5 };
            DoublyLinkedList<int> DlinkedList = new DoublyLinkedList<int>() { 6, 4, 8, 9, 1, 4 };
            Stack<int> stack = new Stack<int>();

            DisplayInList(linkedList);
            DisplayInList(DlinkedList);
            PushStack(stack);
            DisplayInList(stack);
        }

        private static void DisplayInList<T>(System.Collections.Generic.IEnumerable<T> list)
        {
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void PushStack(Stack<int> stack)
        {
            for(int i = 0; i < 10; i++)
            {
                stack.Push(new Random().Next(0, 10));
            }
        }
    }
}

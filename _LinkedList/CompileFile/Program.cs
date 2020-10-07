using _LinkedList;
using DoublyLinkedList;
using System;
using System.Collections;

namespace CompileFile
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>() { 1, 2, 3, 4, 5 };
            DoublyLinkedList<int> DlinkedList = new DoublyLinkedList<int>() { 6, 4, 8, 9, 1, 4 };

            DisplayInList(linkedList);
            DisplayInList(DlinkedList);
        }

        private static void DisplayInList<T>(System.Collections.Generic.IEnumerable<T> list)
        {
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}

using DoublyLinkedList;
using System;

namespace _LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            LinkedList<int> linkedList = new LinkedList<int>();

            for(int i = 0; i < 10; i++)
            {
                linkedList.Add(new Random().Next(0, 100));
            }

            Node<int> node;

            for(node = linkedList.First; node != null; node = node.Next)
            {
                Console.Write(node.Data + " ");
            }

            Console.WriteLine();

            foreach(var item in linkedList)
            {
                Console.Write(item + " ");
            }
            #endregion
            #region DoublyLinkedLisst
            DoublyLinkedList<int> DlinkedList = new DoublyLinkedList<int>();

            for(int i = 0; i < 10; i++)
            {
                DlinkedList.Add(new Random().Next(0, 100));
            }

            foreach(var item in DlinkedList)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}

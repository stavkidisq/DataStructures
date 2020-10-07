using System;

namespace _LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}

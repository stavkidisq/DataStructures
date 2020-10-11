using DoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DataStructures
{
    public class Deque<T>
    {
        int count;
        DoublyNode<T> Head;
        DoublyNode<T> Tail;

        public void AddLast(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if(Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            count++;
        }

        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = Head;
            node.Next = Head;

            if (count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = node;
            }
            count++;
        }
    }
}

using _LinkedList;
using DoublyLinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml;

namespace DataStructures
{
    public class Deque<T> : IEnumerable<T>
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

        public T RemoveFirst()
        {
            if(count == 0)
            {
                throw new NullReferenceException("Дек пуст!");
            }

            T output = Head.Data;

            if (count == 1)
                Head = Tail = null;
            else
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            count--;

            return output;
        }

        public T RemoveLast()
        {
            if (count == 0)
                throw new NullReferenceException("Дек пуст!");
            T output = Tail.Data;

            if (count == 1)
                Head = Tail = null;
            else
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            count--;

            return output;
        }

        public T First
        {
            get
            {
                if (count == 0)
                    throw new NullReferenceException("Дек пуст!");
                else
                    return Head.Data;
            }
        }

        public T Last
        {
            get
            {
                if (count == 0)
                    throw new NullReferenceException("Дек пуст!");
                else
                    return Tail.Data;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            DoublyNode<T> node = Head;

            while(node != null)
            {
                if(data.Equals(node.Data))
                {
                    return true;
                }
                node = node.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            DoublyNode<T> node = Head;

            while(node != null)
            {
                yield return node.Data;

                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

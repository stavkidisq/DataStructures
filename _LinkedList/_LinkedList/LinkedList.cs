using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        Node<T> Head;
        Node<T> Tail;

        int count;

        public Node<T> First => Head;
        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);

            if (Head == null)
                Head = node;
            else
                Tail.Next = node;
            Tail = node;

            count++;
        }

        public bool Remove(T value)
        {
            Node<T> current = Head;
            Node<T> previous = null;

            while (current != null)
            {
                if (previous != null)
                {
                    previous.Next = current;

                    if (current.Next == null)
                    {
                        Tail = previous;
                    }
                }
                else
                {
                    Head = Head.Next;

                    if (Head == null)
                    {
                        Tail = null;
                    }

                    count--;

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public int Count => count;
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            Head = null;
            Tail = null;

            count = 0;
        }

        public void AppendFirst(T value)
        {
            Node<T> node = new Node<T>(value);

            node.Next = Head;
            Head = node;

            if (count == 0)
                Tail = Head;
            count++;
        }

        public bool Contains(T value)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    return true;
                }
                else
                {
                    current = current.Next;
                }
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}

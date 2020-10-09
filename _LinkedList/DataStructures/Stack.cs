using _LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T> : IEnumerable<T>
    {
        Node<T> Head;
        int count;

        public bool IsEmpty { get { return count == 0; } }

        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);

            node.Next = Head;
            Head = node;
            count++;
        }
        public T Pop()
        {
            if (IsEmpty)
            {
                new InvalidCastException("Стек пуст!");
            }

            Node<T> node = Head;
            Head = node.Next;
            count--;

            return node.Data;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                new InvalidCastException("Стек пуст!");
            }

            return Head.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while(current != null)
            {
                yield return current.Data;

                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

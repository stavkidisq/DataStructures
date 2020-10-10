using _LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queue<T> : IEnumerable<T>
    {
        Node<T> Head;
        Node<T> Tail;
        int count;

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> current = Tail;

            Tail = node;

            if (count == 0)
                Head = Tail;
            else
                current.Next = Tail;

            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
                new InvalidCastException("Очередь пуста!");

            T value = Head.Data;
            Head = Head.Next;
            count--;

            return value;
        }

        public T First
        {
            get
            {
                if (count == 0)
                    new InvalidCastException("Очередь пуста!");

                return Head.Data;
            }
        }

        public T Last
        {
            get
            {
                if (count == 0)
                    new InvalidCastException("Очередь пуста!");

                return Tail.Data;
            }
        }

        public int Count => count;
        public bool IsEmpty => count == 0;

        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            var current = Head;

            while(current != null)
            {
                if (current.Data.Equals(data))
                    return true;

                current = current.Next;
            }

            return false;
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

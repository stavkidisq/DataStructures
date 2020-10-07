using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Xml;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        DoublyNode<T> Head;
        DoublyNode<T> Tail;

        int count;
        public int Count => count;
        public bool IsEmpty => count == 0;

        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (Head == null)
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

            node.Next = temp;
            Head = node;

            if(count == 0)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = node;
            }

            count++;
        }

        public bool Remove(T data)
        {
            DoublyNode<T> current = Head;

            while(current != null)
            {
                if(current.Data.Equals(data))
                {
                    break;
                }

                current = current.Next;
            }

            if(current != null)
            {
                if(current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    Tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    Head = current.Next;
                }
                count--;

                return true;
            }

            return false;
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
                if (node.Data.Equals(data))
                {
                    return true;
                }

                node = node.Next;
            }

            return false;
        }

        public IEnumerable<T> BackEnumerator()
        {
            DoublyNode<T> node = Tail;

            while(node != null)
            {
                yield return node.Data;
                node = node.Previous;
            }
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
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}

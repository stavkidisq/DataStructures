using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            Data = data;
        }

        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }

        public T Data { get; set; }
    }
}

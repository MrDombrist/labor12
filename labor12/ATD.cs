using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labor12
{
    class QueueOfString<T>
    {
        private T[] items;
        private int front;
        private int rear;
        private int size;

        public QueueOfString(int capacity)
        {
            items = new T[capacity];
            front = 0;
            rear = 0;
            size = 0;
        }

        public int Count
        {
            get
            {
                return size;
            }
        }

        public void Enqueue(T item)
        {
            if (size == items.Length)
            {
                throw new Exception("Queue is full");
            }

            items[rear] = item;
            rear = (rear + 1) % items.Length;
            size++;
        }

        public T Dequeue()
        {
            if (size == 0)
            {
                throw new Exception("Queue is empty");
            }

            T item = items[front];
            front = (front + 1) % items.Length;
            size--;

            return item;
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new Exception("Queue is empty");
            }

            return items[front];
        }
    }
}

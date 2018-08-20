using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Collections
{
    public class Queue<T> : IEnumerable<T> where T : IComparable<T>
    {
        int head;
        int tail;
        int size;

        T[] collection;

        public Queue()
        {
            collection = new T[0];
        }

        public void Enqueue(T item)
        {
            if (size == collection.Length)
            {
                int num = collection.Length * 2;
                if (num < collection.Length + 4)
                {
                    num = collection.Length + 4;
                }
                Resize(num);
            }
            collection[tail] = item;
            tail = (tail + 1) % collection.Length;
            size++;
        }

        //TODO: Check for maximum size and overflow
        private void Resize(int num)
        {
            T[] newCollection = new T[num];
            if (size > 0)
            {
                if (head < tail)
                {
                    Array.Copy(collection, head, newCollection, 0, size);
                }
                else
                {
                    Array.Copy(collection, head, newCollection, 0, collection.Length - head);
                    Array.Copy(collection, 0, newCollection, collection.Length - head, tail);
                }
            }
            collection = newCollection;
            head = 0;
            tail = ((size == num) ? 0 : size);
        }

        public T Dequeue()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T result = collection[head];
            collection[head] = default(T);
            head = (head + 1) % collection.Length;
            size--;
            return result;
        }

        public T Peek()
        {
            if (size == 0)
                throw new InvalidOperationException("Queue is empty");

            return collection[head];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return collection.GetEnumerator() as IEnumerator<T>;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return collection.GetEnumerator();
        }
    }
}





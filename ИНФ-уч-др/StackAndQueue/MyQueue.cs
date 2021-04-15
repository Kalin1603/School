using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    public class MyQueue<T>
    {
        private List<T> elements;

        public int Count { get { return this.elements.Count; } }

        public MyQueue()
        {
            elements = new List<T>();
        }

        public void Enqueue(T element)
        {
            this.elements.Add(element);
        }

        public T Dequeue()
        {
            if (elements.Count <= 0)
            {
                throw new InvalidOperationException("MyQueue contains no elements");
            }
            T pop = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return pop;
        }

        public T Peek()
        {
            if (elements.Count <= 0)
            {
                throw new InvalidOperationException("MyQueue contains no elements");
            }
            return elements[elements.Count - 1];
        }
        public T[] ToArray()
        {
            return this.elements.ToArray();
        }
    }
}

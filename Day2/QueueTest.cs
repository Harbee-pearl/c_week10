using System;

namespace Day2
{
    public class QueueTest<T>
    {
            public RLLNode<T> Head { get; set; }

            public RLLNode<T> Tail { get; set; }

            public int Count { get; set; }

            public RLLNode<T> Enqueue(T value)
            {
                RLLNode<T> node = new RLLNode<T>(value);

                if (this.Head == null)
                {
                    Head = Tail = node;
                    this.Count++;
                    return node;
                }

                var temp = Tail;
                Tail = node;
                Tail.Next = temp;
                this.Count++;
                return node;
            }

            public T Dequeue()
            {
                if (Head == null)
                {
                    throw new InvalidOperationException("Queue is empty");
                }


                T value = this.Head.Value;
                this.Head = this.Head.Next;
                this.Count--;
                return value;
            }
    }
}
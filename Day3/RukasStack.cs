using System;


namespace Day3
{
    public class RukasStack<T>
    {
        public RLLNode<T> Head {get; set;}

        public RLLNode<T> Tail {get; set;}

        public int Count {get; set;}

        public RLLNode<T> Push(T value)
        {
            RLLNode<T> node = new RLLNode<T>(value);

            if (this.Head == null)
            {
                Head = Tail = node;
                this.Count++;
                return node;
            }

            var temp = Head;
            Head = node;
            Head.Next = temp;
            this.Count++;
            return node;
        }

        public void Print()
        {
            var temp = Head;
            while (temp != null)
            {
                System.Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
}

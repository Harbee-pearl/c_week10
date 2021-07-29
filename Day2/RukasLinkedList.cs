

namespace Day2
{
    public class RukasLinkedList<T>
    {
        public RLLNode<T> Head { get; set; }
        public RLLNode<T> Tail { get; set; }
        public int Count { get; set; }

        public RLLNode<T> AddFirst(T value)
        {
            RLLNode<T> node = new RLLNode<T>(value);

            if (this.Head == null)
            {
                Head = Tail = node;
                this.Count += 1;
                return node;
            }
            
            var temp = Head;
            Head = node;
            Head.Next = temp;
            this.Count += 1;

            return node;
        }

        // public RLLNode<T> 
        public void Print()
        {
            var temp = Head;
            while (temp.Next != null)
            {
                System.Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
        
    }
}
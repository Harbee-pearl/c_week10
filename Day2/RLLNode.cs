namespace Day2
{
    public class RLLNode<T>
    {
        public RLLNode(T value)
        {
            this.Value = value;
        }
        public T Value {get; set;}

        public RLLNode<T> Next { get; set; }
    }
}
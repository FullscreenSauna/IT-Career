using System.Collections.Generic;

namespace Demo.App
{
    public class Node<T>
    {
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; } = new List<Node<T>>();
    }
}

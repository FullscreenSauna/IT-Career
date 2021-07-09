using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Implementation
{
    public class Node<T>
    {
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace Tree_Implementation
{
    public class Tree<T>
    {
        public T Value { get; private set; }

        public List<Tree<T>> Children { get; private set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;

            this.Children = new List<Tree<T>>();

            foreach (var child in children)
                this.Children.Add(child);
        }

        public void DFS(Action<T> action)
        {
            DFS(this, action);
        }

        private void DFS(Tree<T> node, Action<T> action)
        {
            action.Invoke(node.Value);

            if (node.Children.Count > 0)
            {
                foreach (var child in node.Children)
                {
                    DFS(child, action);
                }
            }
        }

        public void BFS(Action<T> action)
        {
            BFS(this, action);
        }

        private void BFS(Tree<T> node, Action<T> action)
        {
            Queue<Tree<T>> queue = new Queue<Tree<T>>();

            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                Tree<T> queueNode = queue.Dequeue();
                action.Invoke(queueNode.Value);

                foreach (var child in queueNode.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }
    }
}

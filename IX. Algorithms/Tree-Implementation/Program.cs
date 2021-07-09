using System;

namespace Tree_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tree<int> tree =
            //    new Tree<int>(7,
            //        new Tree<int>(19,
            //            new Tree<int>(1),
            //            new Tree<int>(12),
            //            new Tree<int>(31)),
            //        new Tree<int>(21),
            //        new Tree<int>(14,
            //            new Tree<int>(23),
            //            new Tree<int>(6)));

            //tree.DFS(elem => Console.WriteLine(elem));
            //Console.WriteLine();
            //tree.BFS(elem => Console.WriteLine(elem));

            BinaryTree<int> binaryTree = new BinaryTree<int>(17
                , new BinaryTree<int>(9, new BinaryTree<int>(3), new BinaryTree<int>(11))
                , new BinaryTree<int>(25, new BinaryTree<int>(20), new BinaryTree<int>(31)));

            binaryTree.PostOrder(Console.WriteLine);
        }
    }
}

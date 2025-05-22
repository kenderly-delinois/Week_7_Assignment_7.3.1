using System.Xml.Linq;

namespace Week_7_Assignment_7._3._1
{
    //
    internal class Program
    {
        //You are given the root of a binary search tree(BST) and an integer val.
        //Find the node in the BST that the node's value equals val 
        //and return the subtree rooted with that node. 
        //If such a node does not exist, return null.


        static void Main(string[] args)
        {
            BST tree = new BST();
            tree.InsertNode(tree.root, 50);
            tree.InsertNode(tree.root, 40);
            tree.InsertNode(tree.root, 70);
            tree.InsertNode(tree.root, 45);
            tree.InsertNode(tree.root, 55);
            tree.InsertNode(tree.root, 60);
            tree.InsertNode(tree.root, 35);

            Console.WriteLine("Inorder: (Note: Left, Root, Right)");
            tree.InOrder(tree.root);

            Console.WriteLine("\n\nPreOrder: (Note: Root, Left, Right)");
            tree.PreOrder(tree.root);

            Console.WriteLine("\n\nPostOrder: (Note: Left, Right, Root)");
            tree.PostOrder(tree.root);

            Console.WriteLine("\n\nSearching for this specific Node: (Node is 50)");
            Node found = tree.Search(50);

            if (found != null)
            {
                Console.WriteLine("Node found: " + found.data);
                if(found.left != null)
                    Console.WriteLine("Left child: " + found.left.data);
                if (found.right != null)
                    Console.WriteLine("Right child: " + found.right.data);
            }
            else
            {
                Console.WriteLine("Node not found");
            }
        }
    }
}

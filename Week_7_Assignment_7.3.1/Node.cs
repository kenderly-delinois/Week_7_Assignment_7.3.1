using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7_Assignment_7._3._1
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data, Node left, Node right) { 
            this.data = data;
            this.left = left;
            this.right = right;
        }
    }

    class BST
    {
        public Node root; // staring point 

        public BST()
        {
            root = null;
        }

        public void InsertNode(Node temproot, int val)
        {
            Node newNode = new Node(val, null ,null);
            Node temp = null;
            if(root != null)
            {
                while(temproot != null)
                {
                    temp = temproot;
                    if(temproot.data == val)
                        return;
                    else if(val < temproot.data) 
                        temproot = temproot.left;
                    else if (val > temproot.data)
                        temproot = temproot.right;
                }
                if(val < temp.data)
                    temp.left = newNode;
                else if(val > temp.data)
                    temp.right = newNode;
            }
            else
            {
                root = newNode;
            }
        }

        public void InOrder(Node temproot)
        {
            if (temproot != null)
            {
                InOrder(temproot.left);
                Console.WriteLine(temproot.data + " ");
                InOrder(temproot.right);
            }
            
        }

        public void PreOrder(Node temproot)
        {
            if(temproot != null)
            {
                Console.WriteLine(temproot.data + " ");
                PreOrder(temproot.left);
                PreOrder(temproot.right);
            }
        }

        public void PostOrder(Node temproot)
        {
            if(temproot != null){
                PostOrder(temproot.left);
                PostOrder(temproot.right);
                Console.WriteLine(temproot.data + " ");
            }
        }

        public Node Search(int n)
        {
            Node temp = root;
            while (temp != null)
            {
                if(temp.data == n)
                {
                    return temp;
                }
                else if(n < temp.data)
                {
                    temp = temp.left;
                }
                else if (n > temp.data)
                {
                    temp = temp.right;
                }
                    
            }
            return temp;
        }
    }
}

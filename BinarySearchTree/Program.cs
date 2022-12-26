using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class node
    {
        public string info;
        public node lchild;
        public node rchild;

        //constructor for the node class

        public node(string i, node l, node r)
        {
            info = i;
            lchild = l;
            rchild = r;
        }
    }

    class BinaryTree
    {
        public node ROOT;
        public BinaryTree()
        {
            ROOT = null; //instalizizng root to null
        }
        public void insert(string element) //insert a node in the binary
        {
            node top, parent = null, currentnode = null;
            find(element, ref parent, ref currentnode);
            if(currentnode != null)//
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else //if the specified node is not present
            {
                tmp = new node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;

                }
                else if (string.Compare(element, parent.info) < 0) 
                {
                    if (string.Compare(element, parent.info) < 0)
                        parent.lchild = tmp;
                }
                else
                {
                    parent.rchild = tmp;
                }
            }
        }
        public void find(string element, ref node parent, ref node currentnode)
        {
            currentnode = ROOT;
            parent = null;
            while ((currentnode != null) && (currentnode.info != element))
            {
                parent = currentnode;
                if (string.Compare(element, currentnode.info) < 0)
                    currentnode = currentnode.lchild;
                else
                    currentnode = currentnode.rchild;
            }
        }
       
        public void inorder (node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("tree is empty");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.lchild);
                Console.WriteLine(ptr.info + " ");
                inorder(ptr.rchild);
            }
        }
        public void preorder (node ptr)
        {
            if(ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + "");
                preorder(ptr.lchild);
                preorder(ptr.rchild);
            }

        }
    }

    






    class Program
    {
        /* A node  class consi
     
     */
       
        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
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

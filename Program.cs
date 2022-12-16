using System;
using System.Collections.Generic;
using BST;
using System.Text;
using System.Threading.Tasks;

public class program
{
    public static void Main (string[] args)
    {
        BST.BinarySearchTree<int> tree = new BST.BinarySearchTree<int>(56);
        tree.AddNode(30);
        tree.AddNode(70);
        tree.Display();

    }
}
  

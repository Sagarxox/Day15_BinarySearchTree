using System;

namespace BST

{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T data;
        public BinarySearchTree<T> Left;
        public BinarySearchTree<T> Right;
        public BinarySearchTree(T data)
        {
            this.data = data;
            this.Left = null;
            this.Right = null;

        }
        int LeftIdx = 0, RightIdx = 0;
        public void AddNode(T Value)
        {
            T NodeValue = this.data;
            if (NodeValue.CompareTo(Value) > 0)
            {
                if (this.Left == null)
                    this.Left = new BinarySearchTree<T>(Value);

                        else 
                    this.Left.AddNode(Value);
            }
            else
            {
                if (this.Right == null )
                    this.Right=new BinarySearchTree<T>(Value);

                else
                    this.Right.AddNode(Value);

            }
        }
        public void Display()
        {
            if(this.Left != null)
            {
                this.LeftIdx++;
                this.Left.Display();
            }
            Console.WriteLine(this.data);
            if (this.Right !=null)
            {
                this.RightIdx++; this.Right.Display();
            }
        }
    }
}
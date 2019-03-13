using System;
using System.Collections.Generic;
using System.Text;

namespace LevelOrderTraversalUsingHeight
{
    class BinaryTreeNode
    {
        int data;
        BinaryTreeNode left;
        BinaryTreeNode right;

        public BinaryTreeNode() { }

        public BinaryTreeNode(int data)
        {
            this.data = data;
        }


        public void SetData(int data)
        {
            this.data = data;
        }

        public void SetLeft(BinaryTreeNode left)
        {
            this.left = left;
        }

        public void SetRight(BinaryTreeNode right)
        {
            this.right = right;
        }

        public BinaryTreeNode GetLeft()
        {
            return left;
        }

        public BinaryTreeNode GetRight()
        {
            return right;
        }

        public int GetData()
        {
            return data;
        }
    }
}

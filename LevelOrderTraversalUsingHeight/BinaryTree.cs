using System;
using System.Collections.Generic;
using System.Text;

namespace LevelOrderTraversalUsingHeight
{
    class BinaryTree
    {
        BinaryTreeNode root;

        public BinaryTree() { }

        public BinaryTree(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public BinaryTreeNode GetRoot() {
            return root;
        }

        public void SetRoot(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public BinaryTreeNode Insert(BinaryTreeNode root, int data) {
            if (root == null) {
                root = new BinaryTreeNode(data);
                return root;
            }
            if (data < root.GetData())
            {
                root.SetLeft(Insert(root.GetLeft(), data));
            }
            else if(data > root.GetData()) {
                root.SetRight(Insert(root.GetRight(), data));
            }

            return root;
        }

        public void PrintInorderTraversal(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }

            PrintInorderTraversal(binaryTreeNode.GetLeft());
            Console.Write(binaryTreeNode.GetData() + " ");
            PrintInorderTraversal(binaryTreeNode.GetRight());
        }

        public int GetHeight(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return 0;
            }

            return Math.Max(GetHeight(binaryTreeNode.GetLeft()),
                GetHeight(binaryTreeNode.GetRight())) + 1 ;
        }

        public void LeftOrderTraversal(BinaryTreeNode binaryTreeNode) {
            int height = GetHeight(binaryTreeNode);

            for (int level = 0; level < height; level++) {
                _PrintLeftOrderTraversal(binaryTreeNode, level);
            }
        }

        public void _PrintLeftOrderTraversal(BinaryTreeNode binaryTreeNode, int level) {
            if (binaryTreeNode == null) {
                return;
            }

            if (level == 0) {
                Console.Write(binaryTreeNode.GetData()+" ");
            }
            _PrintLeftOrderTraversal(binaryTreeNode.GetLeft(), level - 1);
            _PrintLeftOrderTraversal(binaryTreeNode.GetRight(), level-1);
        }
    }
}

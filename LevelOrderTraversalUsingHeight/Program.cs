using System;

namespace LevelOrderTraversalUsingHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Level order Traversal using Height of tree!");
            Console.WriteLine("-------------------------------------------");

            BinaryTree tree = GetTreeFromInput();
            Console.WriteLine("Printing Inorder traversal------------");
            tree.PrintInorderTraversal(tree.GetRoot());
            Console.WriteLine();
            Console.WriteLine("Printing Level order traversal--------");
            tree.LeftOrderTraversal(tree.GetRoot());
            Console.ReadLine();
        }

        private static BinaryTree GetTreeFromInput() {
            BinaryTree binaryTree = null;

            Console.WriteLine("Enter the number of nodes in the Binary tree");
            try
            {
                int numberNodes = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the values of the nodes" +
                    "separated by space");
                binaryTree = new BinaryTree();
                String[] elements = Console.ReadLine().Split(' ');
                for (int i = 0; i < numberNodes; i++)
                {
                    binaryTree.SetRoot(binaryTree.Insert(binaryTree.GetRoot(), 
                        int.Parse(elements[i])));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return binaryTree;
        }
    }
}

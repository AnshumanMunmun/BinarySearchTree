namespace BinarySearchTreeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            Console.WriteLine("Create a Binary Tree :");
            binarySearchTree.InsertData(56);
            binarySearchTree.InsertData(30);
            binarySearchTree.InsertData(70);
            binarySearchTree.InsertData(26);
            binarySearchTree.InsertData(40);
            binarySearchTree.InsertData(80);
            binarySearchTree.Display(binarySearchTree.GetRoot());
        }
    }
}
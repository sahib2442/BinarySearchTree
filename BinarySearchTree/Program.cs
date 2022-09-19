using BinarySearchTree;

class progrm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Binary Search Tree.\n");
        BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
        binarySearchTree.InsertData(56);
        binarySearchTree.InsertData(30);
        binarySearchTree.InsertData(70);
        binarySearchTree.Display(binarySearchTree.GetRoot());
        Console.WriteLine("\n");
        Console.WriteLine("Count of element in binary search:" + binarySearchTree.GetSize());
        bool result = binarySearchTree.SearchTree(56, binarySearchTree.GetRoot());
        Console.WriteLine(result);
    }
}

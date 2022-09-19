using System;
using System.Collections.Generic;
using System.Text;
namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        int count =0;
        bool result = false;
        Node<T> Root;
        Node<T> Current;
        public void InsertData(T data)
        {
            if (Root == null)
            {
                this.Root = new Node<T>(data);
                this.Current = Root;
                count++;
                return;
            }
            if (this.Current.data.CompareTo(data) > 0)
            {
                if (this.Current.leftNode == null)
                {
                    this.Current.leftNode = new Node<T>(data);
                    this.Current = Root;
                    count++;
                }
                else
                {
                    this.Current = this.Current.leftNode;
                    InsertData(data);
                }
            }
            else
            {
                if (this.Current.rightNode == null)
                {
                    this.Current.rightNode = new Node<T>(data);
                    this.Current = Root;
                    count++;
                }
                else
                {
                    this.Current = this.Current.rightNode;
                    InsertData(data);
                }
            }
        }
        public Node<T> GetRoot()
        {
            return this.Root;
        }
        public void Display(Node<T> node)
        {
            if (node != null)
            {
                Display(node.leftNode);
                Console.WriteLine("Element in binary search tree is:" + node.data);
                Display(node.rightNode);
            }
        }
    }
}

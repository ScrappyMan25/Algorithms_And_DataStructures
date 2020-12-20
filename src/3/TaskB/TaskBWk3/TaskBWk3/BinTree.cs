using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBWk3
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;
        public BinTree()
        {
            root = null;
        }
        public BinTree(Node<T> node)
        {
            root = node;
        }

        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }
        public string PreOrder()
        {
            string output = "";
            preOrder(root, ref output);
            return output;
        }
        protected void preOrder(Node<T> node, ref string buffer)
        {
            if (node != null)
            {
                buffer += node.Data.ToString() + "\t";
                preOrder(node.Left, ref buffer);
                preOrder(node.Right, ref buffer);
            }
        }
        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }
        public string InOrder()
        {
            string output = "";
            inOrder(root, ref output);
            return output;
        }
        protected void inOrder(Node<T> node, ref string buffer)
        {
            if (node != null)
            {
                inOrder(node.Left, ref buffer);
                buffer += node.Data.ToString() + "\t";
                inOrder(node.Right, ref buffer);
            }
        }
        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }
        public string PostOrder()
        {
            string output = "";
            postOrder(root, ref output);
            return output;
        }
        protected void postOrder(Node<T> node, ref string buffer)
        {
            if (node != null)
            {
                postOrder(node.Left, ref buffer);
                postOrder(node.Right, ref buffer);
                buffer += node.Data.ToString() + "\t";
            }
        }

        public void Copy(BinTree<T> tree)
        {
            BinTree<T> clonetree = new BinTree<T>();
            copy(ref clonetree.root, tree.root);
            this.root = clonetree.root;
        }
        protected void copy(ref Node<T> node, Node<T> node2)
        {
            if (node2 != null)
            {
                node = new Node<T>(node2.Data);
                copy(ref node.Left, node2.Left);
                copy(ref node.Right, node2.Right);
            }
        }
        public void CopyTo(ref BinTree<T> tree)
        {
            BinTree<T> cloneTree = new BinTree<T>();
            copyTo(root, ref cloneTree.root);
        }
        protected void copyTo(Node<T> node, ref Node<T> node2)
        {
            if (node != null)
            {
                node2 = new Node<T>(node2.Data);
                copyTo(node.Left, ref node2.Left);
                copyTo(node.Right, ref node2.Right);
            }
        }

        public void Count(ref int c)
        {
            count(root, ref c);
        }
        public int Count()
        {
            int c = 0;
            count(root, ref c);
            return c;
        }
        protected void count(Node<T> node, ref int c)
        {
            if (node != null)
            {
                c++;
                count(node.Left, ref c);
                count(node.Right, ref c);
                /*
                 or?
                for protected int count(Node<T> node){}
                return 1 + count(node.Left) + count(node.Right);

                 */
            }
        }
        public int Height()
        {
            return height(root);
        }
        public void Height(ref int h)
        {
            h = height(root);
        }

        protected int height(Node<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(height(node.Left), height(node.Right));
            }
        }

        public bool Equals(BinTree<T> tree)
        {
            return equals(this.root, tree.root);
        }

        private bool equals(Node<T> node1, Node<T> node2)
        {
            if(node1 == null && node2 == null)
            {
                return true;
            }
            else if (node1.Data.CompareTo(node2.Data) == 0)
            {
                return equals(node1.Left, node2.Left) && equals(node1.Right, node2.Right);
            }
            else
            {
                return false;
            }
        }
        public bool SubTree(BinTree<T> tree)
        {
            return subTree(this.root, tree.root);
        }
        protected bool subTree(Node<T> node1, Node<T> node2)
        {
            if (node1 == null ^ node2 == null)
            {
                return false;
            }
            else if (node1 == null && node2 == null)
            {
                return true;
            }
            else if (node1.Data.CompareTo(node2.Data) == 0)
            {
                return subTree(node1.Left, node2.Left) && subTree(node1.Right, node2.Right);
            }
            else
            {
                return subTree(node1.Left, node2) || subTree(node1.Right, node2);
            }
        }


        /*
        //Proof of concept for Equals and SubTree
        public bool Equals(BinTree<T> tree)
        {
            return (this.PreOrder() == tree.PreOrder() && this.InOrder() == tree.InOrder() && this.PostOrder() == tree.PostOrder());
        }
        public bool SubTree(BinTree<T> tree)
        {
            return (this.PreOrder().Contains(tree.PreOrder()) && this.InOrder().Contains(tree.InOrder()) && this.PostOrder().Contains(tree.PostOrder()));
        }
        */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }
        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }
        private void insertItem(T item, ref Node<T> node)
        {
            if (node == null)
            {
                node = new Node<T>(item);
            }
            else if (item.CompareTo(node.Data) < 0)
            {
                insertItem(item, ref node.Left);
            }
            else if (item.CompareTo(node.Data) > 0)
            {
                insertItem(item, ref node.Right);
            }
        }
        public bool Contains(T item)
        {
            return contains(item, ref root);
        }
        protected bool contains(T item, ref Node<T> node)
        {
            if (node == null)
            {
                return false;
            }
            else if (item.CompareTo(node.Data) < 0)
            {
                return contains(item, ref node.Left);
            }
            else if (item.CompareTo(node.Data) > 0)
            {
                return contains(item, ref node.Right);
            }
            else // if == 0 
            {
                return true;
            }
        }
        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }
        private void removeItem(T item, ref Node<T> node)
        {
            if (node == null)//to avoid nullPointer Exceptions
            {
                return;
            }
            else if (item.CompareTo(node.Data) < 0)
            {
                removeItem(item, ref node.Left);
            }
            else if (item.CompareTo(node.Data) > 0)
            {
                removeItem(item, ref node.Right);
            }
            else
            {
                switch (removeItemCase(node))
                {
                    case 1:
                        node = null;
                        break;
                    case 2:
                        node = node.Right;
                        break;
                    case 3:
                        node = node.Left;
                        break;
                    case 4:
                        T temp = leastItem(node.Right);
                        node.Data = temp;
                        removeItem(temp, ref node.Right);
                        break;
                }
            }
        }
        protected T leastItem(Node<T> node)
        {
            if (node.Left == null)
            {
                return node.Data;
            }
            else
            {
                return leastItem(node.Left);
            }
        }

        protected int removeItemCase(Node<T> node)
        {
            if (node.Left == null && node.Right == null)
            {
                return 1;
            }
            else if (node.Left == null)
            {
                return 2;
            }
            else if (node.Right == null)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

    }
}

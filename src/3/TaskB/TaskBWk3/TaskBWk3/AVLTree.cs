using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBWk3
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
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
            node.BalenceFactor = height(node.Left) - height(node.Right);

            if (node.BalenceFactor <= -2)
            {
                rotateLeft(ref node);
            }
            if (node.BalenceFactor >= 2)
            {
                rotateRight(ref node);
            }
        }
        public new void RemoveItem(T item)
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
            if (node != null)
            {
                node.BalenceFactor = height(node.Left) - height(node.Right);

                if (node.BalenceFactor <= -2)
                {
                    rotateLeft(ref node);
                }
                if (node.BalenceFactor >= 2)
                {
                    rotateRight(ref node);
                }
            }
        }

        private void rotateLeft(ref Node<T> node)
        {
            if (node.Right.BalenceFactor > 0)
            {
                rotateRight(ref node.Right);
            }
            Node<T> temp = node;
            node = node.Right;
            temp.Right = node.Left;
            node.Left = temp;
        }
        private void rotateRight(ref Node<T> node)
        {
            if (node.Left.BalenceFactor > 0)
            {
                rotateLeft(ref node.Left);
            }
            Node<T> temp = node;
            node = node.Left;
            temp.Left = node.Right;
            node.Right = temp;
        }

    }
}

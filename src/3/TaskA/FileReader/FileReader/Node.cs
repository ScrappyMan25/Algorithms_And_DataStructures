using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    class Node<T> where T : IComparable
    {
        private T data;
        private int balenceFactor = 0; //Only used for AVLTrees
        public Node<T> Left, Right;

        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }
        public int BalenceFactor
        {
            get { return this.balenceFactor; }
            set { this.balenceFactor = value; }
        }
    }
}

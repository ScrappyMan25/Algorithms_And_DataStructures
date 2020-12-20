using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRequestApp
{
    class LinkGen<T> where T : IComparable
    {
        private T data;
        private LinkGen<T> next;
        public LinkGen(T item)
        {
            this.data = item;
            next = null;
        }
        public LinkGen(T item, LinkGen<T> list)
        {
            this.data = item;
            this.next = list;
        }
        public LinkGen<T> Next
        {
            set { this.next = value; }
            get { return next; }
        }
        public T Data
        {
            set { this.data = value; }
            get { return data; }
        }
    }
}

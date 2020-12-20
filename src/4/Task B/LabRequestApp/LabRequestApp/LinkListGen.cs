
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRequestApp
{
    class LinkListGen<T> where T : IComparable
    {
        protected LinkGen<T> list = null;

        public LinkListGen()
        {
        }
        public void AddItem(T item)
        {
            list = new LinkGen<T>(item, list);
        }
        public string DisplayList()
        {
            StringBuilder output = new StringBuilder();
            LinkGen<T> temp = list;
            while (temp != null)
            {
                output.Append(temp.Data.ToString() + Environment.NewLine);
                temp = temp.Next;
            }
            return output.ToString();
        }
        public int NumberOfItems()
        {
            int c = 0;
            LinkGen<T> temp = list;
            while (temp != null)
            {
                c++;
                temp = temp.Next;
            }
            return c;
        }
        public bool IsPresentItem(T item)
        {

            LinkGen<T> temp = list;
            bool isPresent = false;
            while (temp != null)
            {
                if (temp.Data.CompareTo(item) == 0) { return isPresent = true; }
                temp = temp.Next;
            }
            return isPresent;
        }
        public void AppendItem(T item)
        {
            LinkGen<T> temp = list;
            if (temp == null)
            {
                list = new LinkGen<T>(item);
            }
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new LinkGen<T>(item);
            }
        }
        public void RemoveItem(T item)
        {
            LinkGen<T> temp = list;
            LinkListGen<T> newList = new LinkListGen<T>();

            if (IsPresentItem(item))
            {
                while (temp != null)
                {
                    if (item.CompareTo(temp.Data) != 0)
                    {
                        newList.AppendItem(temp.Data);
                    }
                    temp = temp.Next;
                }
                list = newList.list;
            }
        }

        public void Concat(LinkListGen<T> list2)
        {
            LinkGen<T> temp = list;
            if (temp == null)
            {
                list = list2.list;
            }
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = list2.list;
            }
        }

        public void Copy(LinkListGen<T> list2)
        {
            LinkListGen<T> newList = new LinkListGen<T>();
            LinkGen<T> temp = list2.list;

            while (temp != null)
            {
                newList.AppendItem(temp.Data);
                temp = temp.Next;
            }
            list = newList.list;
        }


        public void InsertInOrder(T item)
        {
            LinkGen<T> temp = list;

            if (temp == null)
            {
                list = new LinkGen<T>(item, list);
            }
            else
            {
                LinkListGen<T> newList = new LinkListGen<T>();
                while (temp != null && temp.Data.CompareTo(item) < 0)
                {
                    newList.AppendItem(temp.Data);
                    temp = temp.Next;
                }
                newList.AppendItem(item);
                if (temp != null)
                {
                    LinkListGen<T> t = new LinkListGen<T>();
                    t.list = temp;
                    newList.Concat(t);
                }
                list = newList.list;
            }
        }

        public void Sort()
        {
            LinkGen<T> temp = list;
            LinkListGen<T> newList = new LinkListGen<T>();
            if (temp == null)
            {
                return;
            }
            else
            {
                newList.AppendItem(temp.Data);
                temp = temp.Next;
                while (temp != null)
                {
                    newList.InsertInOrder(temp.Data);
                    temp = temp.Next;
                }
                list = newList.list;
            }
        }
    }
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRequestApp
{
    class RequestList<Request>: LinkListGen<Request> where Request:IComparable, INextCompare
    {
        public string GreedySearch()
        {
            
            LinkGen<Request> temp = list;
            if (temp == null)
                return "null";
            string s = temp.Data.ToString();
            return s + greedySearch(ref s, temp);
        }
        private string greedySearch(ref string s, LinkGen<Request> list)
        {
            Request temp = list.Data;
            while (list.Next != null && temp.compareNext(list.Next.Data) > 0)
                list = list.Next;
            if (list.Next == null)
                return "";
            else
                return Environment.NewLine + list.Next.Data.ToString() + greedySearch(ref s, list.Next);
            
        }
    }
}

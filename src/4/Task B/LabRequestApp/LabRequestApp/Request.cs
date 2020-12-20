using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRequestApp
{
    public class Request : IComparable, INextCompare
    {
        private string startTime, finishTime;
        private int id;

        public Request(int i, string start, string finish)
        {
            this.id = i;
            this.startTime = start;
            this.finishTime = finish;
        }

        public string StartTime
        {
            get { return startTime; }
            set { this.startTime = value; }
        }
        public string FinishTime
        {
            get { return finishTime; }
            set { this.finishTime = value; }
        }
        public int ID
        {
            get { return id; }
            set { this.id = value; }
        }
        public int CompareTo(Object obj)
        {
            Request other = (Request)obj;
            return finishTime.CompareTo(other.finishTime);
        }
        public int compareNext(Object obj)
        {
            Request other = (Request)obj;
            return finishTime.CompareTo(other.startTime);
        }
        public override string ToString()
        {
            return $"ID: {id}; Start: {startTime}; Finish: {finishTime}" ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{   
    class stringQueue
    {
        private readonly int maxsize = 10;
        private string[] store;
        private int
            head = 0,
            tail = 0,
            numItems = 0;

        public int Head
        {
            get { return head; }
        }

        public int Tail
        {
            get { return tail; }
        }

        public int NumItems
        {
            get { return numItems; }
        }
        public stringQueue()
        {
            store = new string[maxsize];
        }

        public void Enqueue(string value)
        {
            numItems++;
            store[tail++] = value;
            if (tail == maxsize)
            {
                tail = 0;
            }
        }

        public string Dequeue()
        {
            numItems--;
            string t = store[head++];
            if (head == maxsize)
            {
                head = 0;
            }
            return t;
        }

        public string Peek()
        {
            // insert code
            return store[head];
        }

        public bool IsEmpty()
        {
            return numItems == 0;
        }

        public bool IsFull()
        {
            return numItems == maxsize;
        }

        public string Print()
        {
            StringBuilder output = new StringBuilder();
            int i = head;
            do
            {
                output.Append(store[i++] + "\t");
                if (i == maxsize) { i = 0; }
            } while (i != tail);
            return output.ToString();
        }

    }
}

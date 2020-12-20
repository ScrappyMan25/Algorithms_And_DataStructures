using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks
{
    class Book : IComparable
    {
        private string author = "Unknown";
        private string title = "Unknown";
        private string isbn = "Unknown";

        public string Isbn
        {
            get { return isbn; }
            set { this.isbn = value; }
        }
        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return author; }
            set { this.author = value; }
        }

        public Book() { }
        
        public Book(string i)
        {
            this.isbn = i;
        }
        public Book(string i, string t)
        {
            this.isbn = i;
            this.title = t;
        }
        public Book(string i, string t, string a)
        {
            this.isbn = i;
            this.title = t;
            this.author = a;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(Environment.NewLine + "ISBN: " + Isbn + "\tTitle: " + Title + "\tAuthor: " + Author);

            return output.ToString();
        }

        public int CompareTo(Object obj)
        {
            Book other = (Book)obj;
            return Isbn.CompareTo(other.Isbn);
        }
    }
}

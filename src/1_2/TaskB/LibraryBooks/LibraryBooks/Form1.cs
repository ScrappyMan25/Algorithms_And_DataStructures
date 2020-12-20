using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBooks
{
    public partial class Form1 : Form
    {
        LinkListGen<Book> Books = new LinkListGen<Book>();

        Book testBook = new Book("test");
        Book input = new Book();

        string status;

        string Err1 = "Error 1 : Empty Input Field Detected";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtnClick(object sender, EventArgs e)
        {

            if (checkInput()) 
            {   
                input = new Book(isbnInput.Text, titleInput.Text, authorInput.Text);

                if (!Books.IsPresentItem(input))
                {
                    Books.AddItem(input);
                    status = $"Book [ISBN: {input.Isbn}] succesfully added to the List.";
                }
                else
                {
                    status = $"Book [ISBN: {input.Isbn}] already in list.";
                }
                updateBooks(status);
            }
        }

        private void rmvBtnCLick(object sender, EventArgs e)
        {
            if (checkInput()) 
            {
                input = new Book(isbnInput.Text, titleInput.Text, authorInput.Text);
                if (Books.NumberOfItems() != 0 && Books.IsPresentItem(input))
                {
                    Books.RemoveItem(input);
                    clearFields();
                    status = $"Books [ISBN: {input.Isbn}] removed from list.";
                }
                else if (!Books.IsPresentItem(input)) 
                {
                    status = $"Book [ISBN: {input.Isbn}] not found in list."; ;
                }
                else
                {
                    status = "List is empty. Nothing to remove.";
                }
                updateBooks(status);
            }
        }

        private void sortBtnClick(object sender, EventArgs e)
        {
            Books.Sort();
            status = "List sorted.";
            updateBooks(status);
            
        }

        private void insertBtnClick(object sender, EventArgs e)
        {
            if (checkInput())
            {
                input = new Book(isbnInput.Text, titleInput.Text, authorInput.Text);
                if (!Books.IsPresentItem(input))
                    {
                    Books.Sort();
                    Books.InsertInOrder(input);
                    string status = $"Book [ISBN: {input.Isbn}] succesfully added in order to the List.";
                }
                else
                {
                    status = $"Book [ISBN: {input.Isbn}] already in list.";
                }
                updateBooks(status);
            }
        }

        private bool checkInput()
        {
            testBook.Isbn = isbnInput.Text;
            if(isbnInput.Text == "" || titleInput.Text == "" || authorInput.Text == "")
            {
                clearFields();
                MessageBox.Show(Err1);
                return (false);
            }
            return true;
        }

        private void clearFields() 
        {
            isbnInput.Clear();
            titleInput.Clear();
            authorInput.Clear();
            isbnInput.Focus();
        }
        private void updateBooks()
        {
            statusLabel.Text = "null";
            clearFields();
            displayBooks.Text = Books.DisplayList();
            count.Text = Books.NumberOfItems().ToString();
        }

        private void updateBooks(string s)
        {
            statusLabel.Text = s;
            clearFields();
            displayBooks.Text = Books.DisplayList();
            count.Text = Books.NumberOfItems().ToString();
        }

        private void resetBtnClick(object sender, EventArgs e)
        {
            Books = new LinkListGen<Book>();
            status = "List has been reset";
            updateBooks(status);
        }
    }
}

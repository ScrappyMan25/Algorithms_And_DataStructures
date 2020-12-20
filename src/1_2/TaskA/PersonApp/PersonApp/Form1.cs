using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    public partial class Form1 : Form
    {
            stringQueue personQueue = new stringQueue();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateCounter()
        {
            queueCount.Text = personQueue.NumItems.ToString();
            if (personQueue.IsFull())
            {
                addButton.Enabled = false;
            }
            else
            {
                addButton.Enabled = true;
            }
        }

        private void addButtonClick(object sender, EventArgs e)
        {
            if (nameInput.Text != "" && !personQueue.IsFull())
            {
                personQueue.Enqueue(nameInput.Text);
                updateCounter();
                nameInput.Text = "";
                nameInput.Focus();
            }
            
        }

        private void popButtonClick(object sender, EventArgs e)
        {
            if (!personQueue.IsEmpty())
            {
                poppedName.Text = personQueue.Dequeue();
                updateCounter();
            }
            else
            {
                poppedName.Text = "Sorry. No names in queue";
            }
        }
    }
}

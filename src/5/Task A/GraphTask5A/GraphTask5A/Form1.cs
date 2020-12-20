using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphTask5A
{
    public partial class Form1 : Form
    {
        Graph<char> charGraph = new Graph<char>();
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertNodeBtn_Click(object sender, EventArgs e)
        {
            if(nodeInput.Text == "")
                Error("Error: Empty Input Field");
            else if (charGraph.GetNodeByID(Convert.ToChar(nodeInput.Text)) != null)
                Error("Error: Node Already Exists");
            else
            {
                charGraph.AddNode(Convert.ToChar(nodeInput.Text));
            }
            UpdateCounter();
            
        }
        private void AddEdgeBtn_Click(object sender, EventArgs e)
        {
            if(fromInput.Text == "" || toInput.Text == "")
                Error("Error: Empty Input Field");
            else if (charGraph.GetNodeByID(Convert.ToChar(fromInput.Text)) == null)
                Error($"Error: Node |{fromInput.Text}| Doesnt Exist");
            else if (charGraph.GetNodeByID(Convert.ToChar(toInput.Text)) == null)
                Error($"Error: Node |{toInput.Text}| Doesnt Exist");
            else if(charGraph.GetNodeByID(Convert.ToChar(fromInput.Text)).GetAdjList().Contains(Convert.ToChar(toInput.Text)))
                Error($"Error: Node |{toInput.Text}| exists as a Connection from Node |{toInput.Text}|");
            else
            {
                charGraph.AddEdge(Convert.ToChar(fromInput.Text), Convert.ToChar(toInput.Text));
            }
            UpdateCounter();
        }

        public void UpdateCounter()
        {
            nodeInput.Clear();
            fromInput.Clear();
            toInput.Clear();
            nodeCountLbl.Text = charGraph.NumNodesGraph().ToString();
            EdgeCountLbl.Text = charGraph.NumEdgesGraph().ToString();
            displayGraph.Text = charGraph.DisplayGraph();
            nodeInput.Focus();
        }

        public void Error(string e)
        {
            MessageBox.Show(e);
        }

    }
}

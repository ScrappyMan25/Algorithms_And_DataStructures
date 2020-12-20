using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5B
{
    public partial class Form1 : Form
    {
        Graph<string> AirportGraph = new Graph<string>();
        
        List<string> Reachability;// = new List<string>();

        public Form1()
        {
            InitializeComponent();
            
            testInitialise();
        }

        private void InsertAirportNode_Click(object sender, EventArgs e)
        {
            if (nodeInput.Text == "")
                Error("Error: Empty Input Field");
            else if (AirportGraph.GetNodeByID(nodeInput.Text) != null)
                Error("Error: Airport Already Exists");
            else
            {
                AirportGraph.AddNode(nodeInput.Text);
                UpdateAirportList(nodeInput.Text);
            }

            UpdateForm();
        }

        private void AddEdgeBtn_Click(object sender, EventArgs e)
        {
            if (fromInput.Text == "" || toInput.Text == "")
                Error("Error: Empty Input Field");
            else if (AirportGraph.GetNodeByID(fromInput.Text) == null)
                Error($"Error: Airport |{fromInput.Text}| Doesnt Exist");
            else if ((AirportGraph.GetNodeByID(toInput.Text) == null))
                Error($"Error: Airport |{toInput.Text}| Doesnt Exist");
            else if (AirportGraph.GetNodeByID(fromInput.Text).GetAdjList().Contains(toInput.Text))
                Error($"Error: Airport |{toInput.Text}| has a Connection from Airport |{toInput.Text}|");
            else
            {
                AirportGraph.AddEdge((fromInput.Text), (toInput.Text));
            }
            UpdateForm();
        }

        private void RmvEdgeBtn_Click(object sender, EventArgs e)
        {
            if (fromInput.Text == "" || toInput.Text == "")
                Error("Error: Empty Input Field");
            else if (AirportGraph.GetNodeByID(fromInput.Text) == null)
                Error($"Error: Airport |{fromInput.Text}| Doesnt Exist");
            else if ((AirportGraph.GetNodeByID(toInput.Text) == null))
                Error($"Error: Airport |{toInput.Text}| Doesnt Exist");
            else if (!AirportGraph.GetNodeByID(fromInput.Text).GetAdjList().Contains(toInput.Text))
                Error($"Error: Airport |{toInput.Text}| does not have a Connection from Airport |{toInput.Text}|");
            else
            {
                AirportGraph.RemoveEdge((fromInput.Text), (toInput.Text));
            }
            UpdateForm();
        }

        private void lookUpBtn_Click(object sender, EventArgs e)
        {
            if (lookupInput.Text == "")
                Error("Error: Empty Input Field");
            else if (AirportGraph.GetNodeByID(lookupInput.Text) == null)
            {
                Error($"Error: Airport |{lookupInput.Text}| Doesnt Exist"); 
                UpdateForm();
            }
            else
            {
                LookupDisplay.Clear();
                Reachability = new List<string>();
                AirportGraph.DepthFirstTraverse(lookupInput.Text, ref Reachability);
                foreach(string a in Reachability)
                {
                    if (a != lookupInput.Text)
                        LookupDisplay.AppendText(a + Environment.NewLine);
                }
            }
        }
        public void Error(string e)
        {
            MessageBox.Show(e);
        }
        public void UpdateForm()
        {
            nodeInput.Clear();
            fromInput.Clear();
            toInput.Clear();
            
            lookupInput.Clear();
            LookupDisplay.Clear();

            nodeInput.Focus();
            UpdateMotherList();
        }

        public void UpdateMotherList()
        {
            string output = "";
            foreach(string airport in AirportGraph.Mothervertex())
            {
                output += airport + Environment.NewLine;
            }
            MotherAirportsDisplay.Text = output;
        }
        public void UpdateAirportList(string newAirport)
        {
            AllAirportsDisplay.AppendText(newAirport + Environment.NewLine);
        }

        public void testInitialise()
        {
            string[] AirportCodes =
           {
            "mad",
            "bru",
            "lcy",
            "waw",
            "cdg",
            "mxp",
            "ber",
            "lux",
            "ams",
            "lis"
            };

            foreach (string a in AirportCodes)
            {
                AirportGraph.AddNode(a);
                UpdateAirportList(a);
            }
            
            UpdateForm();

        }
    }
}

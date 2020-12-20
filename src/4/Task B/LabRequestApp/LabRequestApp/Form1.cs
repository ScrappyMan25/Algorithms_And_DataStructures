using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LabRequestApp
{
    public partial class Form1 : Form
    {
        RequestList<Request> requests = new RequestList<Request>();   
        public Form1()
        {
            InitializeComponent();
            idInput.Controls[0].Visible = false;
            testInitialise();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void updateFields(string r)
        {
            idInput.Value = 0;
            startHour.Value = 00;
            startMin.Value = 00;
            finishHour.Value = 00;
            finishMin.Value = 00;
            idInput.Focus();

            allRequests.AppendText(r + Environment.NewLine);
            testBox.Clear();
            testBox.AppendText(requests.GreedySearch());
        }

        public bool validateInputs(string start, string finish)
        {
            if(start == finish || finish.CompareTo(start) < 0)
            {
                MessageBox.Show("Invalid Time Inputs.");
                return false;
            }

            return true;
        }

        public string timeFormatter(decimal h, decimal m)
        {
            string hour, min;
            if (h < 10)
                hour = h.ToString().PadLeft(2, '0');
            else
                hour = h.ToString();
            if (m < 10)
                min = m.ToString().PadLeft(2, '0');
            else
                min = m.ToString();
            return hour + ':' + min;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string start = timeFormatter(startHour.Value, startMin.Value);
            string finish = timeFormatter(finishHour.Value, finishMin.Value);

            if (validateInputs(start, finish))
            {
                int id = Convert.ToInt32(idInput.Value);
                Request r = new Request(id, start, finish);
                requests.InsertInOrder(r);
                updateFields(r.ToString());

            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            allRequests.Clear();
            testBox.Clear();
            requests = null;

            idInput.Value = 0;
            startHour.Value = 00;
            startMin.Value = 00;
            finishHour.Value = 00;
            finishMin.Value = 00;
            idInput.Focus();
        }

        public void testInitialise()
        {
            int[] IDs               = {1, 2, 3, 4, 5, 6}; 
            string[] startTimes     = 
                {
                "12:00",
                "12:30",
                "16:30",
                "13:40",
                "12:10",
                "12:05"
            
            }; 
            string[] finishTimes =
                {
                "13:45",
                "12:45",
                "16:45",
                "15:35",
                "14:30",
                "15:10"
            };

            for (int i = 0; i < 6; i++) 
            {
                Request temp = new Request(IDs[i], startTimes[i], finishTimes[i]);
                requests.InsertInOrder(temp);
                updateFields(temp.ToString()) ;
            }
        }
    }
}
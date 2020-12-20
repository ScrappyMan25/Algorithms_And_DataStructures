namespace Task5B
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InsertAirportNode = new System.Windows.Forms.Button();
            this.AddEdgeBtn = new System.Windows.Forms.Button();
            this.RmvEdgeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nodeInput = new System.Windows.Forms.TextBox();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.toInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AllAirportsDisplay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LookupDisplay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MotherAirportsDisplay = new System.Windows.Forms.TextBox();
            this.lookupInput = new System.Windows.Forms.TextBox();
            this.lookUpBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InsertAirportNode
            // 
            this.InsertAirportNode.Location = new System.Drawing.Point(454, 67);
            this.InsertAirportNode.Name = "InsertAirportNode";
            this.InsertAirportNode.Size = new System.Drawing.Size(158, 29);
            this.InsertAirportNode.TabIndex = 2;
            this.InsertAirportNode.Text = "Insert Airport";
            this.InsertAirportNode.UseVisualStyleBackColor = true;
            this.InsertAirportNode.Click += new System.EventHandler(this.InsertAirportNode_Click);
            // 
            // AddEdgeBtn
            // 
            this.AddEdgeBtn.Location = new System.Drawing.Point(454, 125);
            this.AddEdgeBtn.Name = "AddEdgeBtn";
            this.AddEdgeBtn.Size = new System.Drawing.Size(158, 29);
            this.AddEdgeBtn.TabIndex = 5;
            this.AddEdgeBtn.Text = "Add Connectivity";
            this.AddEdgeBtn.UseVisualStyleBackColor = true;
            this.AddEdgeBtn.Click += new System.EventHandler(this.AddEdgeBtn_Click);
            // 
            // RmvEdgeBtn
            // 
            this.RmvEdgeBtn.Location = new System.Drawing.Point(631, 125);
            this.RmvEdgeBtn.Name = "RmvEdgeBtn";
            this.RmvEdgeBtn.Size = new System.Drawing.Size(158, 29);
            this.RmvEdgeBtn.TabIndex = 6;
            this.RmvEdgeBtn.Text = "Remove Connectivity";
            this.RmvEdgeBtn.UseVisualStyleBackColor = true;
            this.RmvEdgeBtn.Click += new System.EventHandler(this.RmvEdgeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Airport Application";
            // 
            // nodeInput
            // 
            this.nodeInput.Location = new System.Drawing.Point(304, 65);
            this.nodeInput.Name = "nodeInput";
            this.nodeInput.Size = new System.Drawing.Size(129, 22);
            this.nodeInput.TabIndex = 1;
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(304, 108);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(129, 22);
            this.fromInput.TabIndex = 3;
            // 
            // toInput
            // 
            this.toInput.Location = new System.Drawing.Point(304, 135);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(129, 22);
            this.toInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Airport Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Configure Connectivity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "To:";
            // 
            // AllAirportsDisplay
            // 
            this.AllAirportsDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.AllAirportsDisplay.Location = new System.Drawing.Point(11, 244);
            this.AllAirportsDisplay.Multiline = true;
            this.AllAirportsDisplay.Name = "AllAirportsDisplay";
            this.AllAirportsDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AllAirportsDisplay.Size = new System.Drawing.Size(255, 194);
            this.AllAirportsDisplay.TabIndex = 11;
            this.AllAirportsDisplay.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "List Of Airport Codes:";
            // 
            // LookupDisplay
            // 
            this.LookupDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.LookupDisplay.Location = new System.Drawing.Point(272, 244);
            this.LookupDisplay.Multiline = true;
            this.LookupDisplay.Name = "LookupDisplay";
            this.LookupDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LookupDisplay.Size = new System.Drawing.Size(255, 194);
            this.LookupDisplay.TabIndex = 13;
            this.LookupDisplay.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Reachability From: ";
            // 
            // MotherAirportsDisplay
            // 
            this.MotherAirportsDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.MotherAirportsDisplay.Location = new System.Drawing.Point(533, 244);
            this.MotherAirportsDisplay.Multiline = true;
            this.MotherAirportsDisplay.Name = "MotherAirportsDisplay";
            this.MotherAirportsDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MotherAirportsDisplay.Size = new System.Drawing.Size(255, 194);
            this.MotherAirportsDisplay.TabIndex = 15;
            this.MotherAirportsDisplay.TabStop = false;
            // 
            // lookupInput
            // 
            this.lookupInput.Location = new System.Drawing.Point(278, 215);
            this.lookupInput.Name = "lookupInput";
            this.lookupInput.Size = new System.Drawing.Size(129, 22);
            this.lookupInput.TabIndex = 7;
            // 
            // lookUpBtn
            // 
            this.lookUpBtn.Location = new System.Drawing.Point(413, 215);
            this.lookUpBtn.Name = "lookUpBtn";
            this.lookUpBtn.Size = new System.Drawing.Size(92, 26);
            this.lookUpBtn.TabIndex = 8;
            this.lookUpBtn.Text = "Lookup";
            this.lookUpBtn.UseVisualStyleBackColor = true;
            this.lookUpBtn.Click += new System.EventHandler(this.lookUpBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(529, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mother Airport Codes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lookUpBtn);
            this.Controls.Add(this.lookupInput);
            this.Controls.Add(this.MotherAirportsDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LookupDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AllAirportsDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.nodeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RmvEdgeBtn);
            this.Controls.Add(this.AddEdgeBtn);
            this.Controls.Add(this.InsertAirportNode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertAirportNode;
        private System.Windows.Forms.Button AddEdgeBtn;
        private System.Windows.Forms.Button RmvEdgeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nodeInput;
        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.TextBox toInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AllAirportsDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LookupDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MotherAirportsDisplay;
        private System.Windows.Forms.TextBox lookupInput;
        private System.Windows.Forms.Button lookUpBtn;
        private System.Windows.Forms.Label label8;
    }
}


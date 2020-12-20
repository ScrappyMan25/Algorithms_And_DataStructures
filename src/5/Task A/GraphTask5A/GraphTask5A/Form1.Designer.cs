namespace GraphTask5A
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
            this.nodeInput = new System.Windows.Forms.TextBox();
            this.InsertNodeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddEdgeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nodeCountLbl = new System.Windows.Forms.Label();
            this.EdgeCountLbl = new System.Windows.Forms.Label();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.toInput = new System.Windows.Forms.TextBox();
            this.displayGraph = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nodeInput
            // 
            this.nodeInput.Location = new System.Drawing.Point(295, 119);
            this.nodeInput.MaxLength = 1;
            this.nodeInput.Name = "nodeInput";
            this.nodeInput.Size = new System.Drawing.Size(131, 22);
            this.nodeInput.TabIndex = 0;
            // 
            // InsertNodeBtn
            // 
            this.InsertNodeBtn.Location = new System.Drawing.Point(606, 115);
            this.InsertNodeBtn.Name = "InsertNodeBtn";
            this.InsertNodeBtn.Size = new System.Drawing.Size(111, 24);
            this.InsertNodeBtn.TabIndex = 1;
            this.InsertNodeBtn.Text = "Insert Node";
            this.InsertNodeBtn.UseVisualStyleBackColor = true;
            this.InsertNodeBtn.Click += new System.EventHandler(this.InsertNodeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Graphs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Node:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Directed Edge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "to";
            // 
            // AddEdgeBtn
            // 
            this.AddEdgeBtn.Location = new System.Drawing.Point(606, 159);
            this.AddEdgeBtn.Name = "AddEdgeBtn";
            this.AddEdgeBtn.Size = new System.Drawing.Size(111, 24);
            this.AddEdgeBtn.TabIndex = 8;
            this.AddEdgeBtn.Text = "Add Edge";
            this.AddEdgeBtn.UseVisualStyleBackColor = true;
            this.AddEdgeBtn.Click += new System.EventHandler(this.AddEdgeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nodes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Edges:";
            // 
            // nodeCountLbl
            // 
            this.nodeCountLbl.AutoSize = true;
            this.nodeCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeCountLbl.Location = new System.Drawing.Point(684, 40);
            this.nodeCountLbl.Name = "nodeCountLbl";
            this.nodeCountLbl.Size = new System.Drawing.Size(18, 20);
            this.nodeCountLbl.TabIndex = 11;
            this.nodeCountLbl.Text = "0";
            // 
            // EdgeCountLbl
            // 
            this.EdgeCountLbl.AutoSize = true;
            this.EdgeCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdgeCountLbl.Location = new System.Drawing.Point(684, 60);
            this.EdgeCountLbl.Name = "EdgeCountLbl";
            this.EdgeCountLbl.Size = new System.Drawing.Size(18, 20);
            this.EdgeCountLbl.TabIndex = 12;
            this.EdgeCountLbl.Text = "0";
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(295, 161);
            this.fromInput.MaxLength = 1;
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(131, 22);
            this.fromInput.TabIndex = 13;
            // 
            // toInput
            // 
            this.toInput.Location = new System.Drawing.Point(452, 161);
            this.toInput.MaxLength = 1;
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(131, 22);
            this.toInput.TabIndex = 14;
            // 
            // displayGraph
            // 
            this.displayGraph.Location = new System.Drawing.Point(12, 279);
            this.displayGraph.MaxLength = 1;
            this.displayGraph.Multiline = true;
            this.displayGraph.Name = "displayGraph";
            this.displayGraph.Size = new System.Drawing.Size(776, 159);
            this.displayGraph.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayGraph);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.EdgeCountLbl);
            this.Controls.Add(this.nodeCountLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddEdgeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertNodeBtn);
            this.Controls.Add(this.nodeInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nodeInput;
        private System.Windows.Forms.Button InsertNodeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddEdgeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nodeCountLbl;
        private System.Windows.Forms.Label EdgeCountLbl;
        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.TextBox toInput;
        private System.Windows.Forms.TextBox displayGraph;
    }
}


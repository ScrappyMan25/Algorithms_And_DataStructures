namespace LabRequestApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allRequests = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.startHour = new System.Windows.Forms.NumericUpDown();
            this.finishHour = new System.Windows.Forms.NumericUpDown();
            this.finishMin = new System.Windows.Forms.NumericUpDown();
            this.startMin = new System.Windows.Forms.NumericUpDown();
            this.idInput = new System.Windows.Forms.NumericUpDown();
            this.testBox = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Time (HH:MM):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Finish Time (HH:MM):";
            // 
            // allRequests
            // 
            this.allRequests.BackColor = System.Drawing.SystemColors.Control;
            this.allRequests.Cursor = System.Windows.Forms.Cursors.No;
            this.allRequests.Location = new System.Drawing.Point(451, 60);
            this.allRequests.Multiline = true;
            this.allRequests.Name = "allRequests";
            this.allRequests.ReadOnly = true;
            this.allRequests.Size = new System.Drawing.Size(337, 378);
            this.allRequests.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "All Requests:";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(292, 92);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(148, 34);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add New Request";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "H";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "H";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(254, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "M";
            // 
            // startHour
            // 
            this.startHour.Location = new System.Drawing.Point(155, 64);
            this.startHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.startHour.Name = "startHour";
            this.startHour.ReadOnly = true;
            this.startHour.Size = new System.Drawing.Size(42, 22);
            this.startHour.TabIndex = 2;
            // 
            // finishHour
            // 
            this.finishHour.Location = new System.Drawing.Point(155, 96);
            this.finishHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.finishHour.Name = "finishHour";
            this.finishHour.ReadOnly = true;
            this.finishHour.Size = new System.Drawing.Size(42, 22);
            this.finishHour.TabIndex = 4;
            // 
            // finishMin
            // 
            this.finishMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.finishMin.Location = new System.Drawing.Point(216, 96);
            this.finishMin.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.finishMin.Name = "finishMin";
            this.finishMin.ReadOnly = true;
            this.finishMin.Size = new System.Drawing.Size(42, 22);
            this.finishMin.TabIndex = 5;
            // 
            // startMin
            // 
            this.startMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.startMin.Location = new System.Drawing.Point(216, 64);
            this.startMin.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.startMin.Name = "startMin";
            this.startMin.ReadOnly = true;
            this.startMin.Size = new System.Drawing.Size(42, 22);
            this.startMin.TabIndex = 3;
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(155, 31);
            this.idInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(103, 22);
            this.idInput.TabIndex = 1;
            // 
            // testBox
            // 
            this.testBox.BackColor = System.Drawing.SystemColors.Control;
            this.testBox.Cursor = System.Windows.Forms.Cursors.No;
            this.testBox.Location = new System.Drawing.Point(28, 270);
            this.testBox.Multiline = true;
            this.testBox.Name = "testBox";
            this.testBox.ReadOnly = true;
            this.testBox.Size = new System.Drawing.Size(389, 152);
            this.testBox.TabIndex = 16;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(322, 132);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 29);
            this.ResetBtn.TabIndex = 17;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(359, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Higest Number of Requests That Can Be Accomodated:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.finishMin);
            this.Controls.Add(this.startMin);
            this.Controls.Add(this.finishHour);
            this.Controls.Add(this.startHour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allRequests);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox allRequests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown startHour;
        private System.Windows.Forms.NumericUpDown finishHour;
        private System.Windows.Forms.NumericUpDown finishMin;
        private System.Windows.Forms.NumericUpDown startMin;
        private System.Windows.Forms.NumericUpDown idInput;
        private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label9;
    }
}


namespace PersonApp
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
            this.Header = new System.Windows.Forms.Label();
            this.peopleNoLabel = new System.Windows.Forms.Label();
            this.queueCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.popButton = new System.Windows.Forms.Button();
            this.poppedName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(225, 27);
            this.Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(133, 18);
            this.Header.TabIndex = 0;
            this.Header.Text = "Person Queue App";
            this.Header.Click += new System.EventHandler(this.label1_Click);
            // 
            // peopleNoLabel
            // 
            this.peopleNoLabel.AutoSize = true;
            this.peopleNoLabel.Location = new System.Drawing.Point(242, 74);
            this.peopleNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.peopleNoLabel.Name = "peopleNoLabel";
            this.peopleNoLabel.Size = new System.Drawing.Size(80, 13);
            this.peopleNoLabel.TabIndex = 1;
            this.peopleNoLabel.Text = "No. Of People: ";
            // 
            // queueCount
            // 
            this.queueCount.AutoSize = true;
            this.queueCount.Location = new System.Drawing.Point(326, 74);
            this.queueCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.queueCount.Name = "queueCount";
            this.queueCount.Size = new System.Drawing.Size(13, 13);
            this.queueCount.TabIndex = 2;
            this.queueCount.Text = "0";
            this.queueCount.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add New Person Name:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(272, 129);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(105, 20);
            this.nameInput.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(404, 128);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 21);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Enqueue";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButtonClick);
            // 
            // popButton
            // 
            this.popButton.Location = new System.Drawing.Point(184, 213);
            this.popButton.Margin = new System.Windows.Forms.Padding(2);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(275, 26);
            this.popButton.TabIndex = 6;
            this.popButton.Text = "Click here to Remove and Display Name from queue";
            this.popButton.UseVisualStyleBackColor = true;
            this.popButton.Click += new System.EventHandler(this.popButtonClick);
            // 
            // poppedName
            // 
            this.poppedName.AutoSize = true;
            this.poppedName.Location = new System.Drawing.Point(303, 264);
            this.poppedName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poppedName.Name = "poppedName";
            this.poppedName.Size = new System.Drawing.Size(0, 13);
            this.poppedName.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.poppedName);
            this.Controls.Add(this.popButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queueCount);
            this.Controls.Add(this.peopleNoLabel);
            this.Controls.Add(this.Header);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label peopleNoLabel;
        private System.Windows.Forms.Label queueCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button popButton;
        private System.Windows.Forms.Label poppedName;
    }
}


namespace LibraryBooks
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
            this.isbnInput = new System.Windows.Forms.TextBox();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.rmvBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.insertInOrderBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.displayBooks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // isbnInput
            // 
            this.isbnInput.Location = new System.Drawing.Point(87, 63);
            this.isbnInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isbnInput.Name = "isbnInput";
            this.isbnInput.Size = new System.Drawing.Size(76, 20);
            this.isbnInput.TabIndex = 3;
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(87, 104);
            this.titleInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(76, 20);
            this.titleInput.TabIndex = 4;
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(87, 141);
            this.authorInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(76, 20);
            this.authorInput.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(200, 45);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(92, 19);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtnClick);
            // 
            // rmvBtn
            // 
            this.rmvBtn.Location = new System.Drawing.Point(200, 83);
            this.rmvBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rmvBtn.Name = "rmvBtn";
            this.rmvBtn.Size = new System.Drawing.Size(92, 19);
            this.rmvBtn.TabIndex = 7;
            this.rmvBtn.Text = "Remove";
            this.rmvBtn.UseVisualStyleBackColor = true;
            this.rmvBtn.Click += new System.EventHandler(this.rmvBtnCLick);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(200, 122);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(92, 19);
            this.sortBtn.TabIndex = 8;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtnClick);
            // 
            // insertInOrderBtn
            // 
            this.insertInOrderBtn.Location = new System.Drawing.Point(200, 166);
            this.insertInOrderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertInOrderBtn.Name = "insertInOrderBtn";
            this.insertInOrderBtn.Size = new System.Drawing.Size(92, 19);
            this.insertInOrderBtn.TabIndex = 9;
            this.insertInOrderBtn.Text = "Insert In Order";
            this.insertInOrderBtn.UseVisualStyleBackColor = true;
            this.insertInOrderBtn.Click += new System.EventHandler(this.insertBtnClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of Books: ";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(116, 180);
            this.count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(13, 13);
            this.count.TabIndex = 11;
            this.count.Text = "0";
            // 
            // displayBooks
            // 
            this.displayBooks.Location = new System.Drawing.Point(316, 26);
            this.displayBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayBooks.Multiline = true;
            this.displayBooks.Name = "displayBooks";
            this.displayBooks.Size = new System.Drawing.Size(302, 223);
            this.displayBooks.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Library Books";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(68, 214);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 15;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(200, 11);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(92, 19);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "ResetList";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 258);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.displayBooks);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertInOrderBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.rmvBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.isbnInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbnInput;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox authorInput;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button rmvBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button insertInOrderBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.TextBox displayBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button resetBtn;
    }
}


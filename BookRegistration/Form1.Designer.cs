namespace BookRegistration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRegisterBook = new System.Windows.Forms.Button();
            this.cbxCustomers = new System.Windows.Forms.ComboBox();
            this.cbxBooks = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(545, 29);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(194, 92);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(545, 159);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(194, 90);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnRegisterBook
            // 
            this.btnRegisterBook.Location = new System.Drawing.Point(224, 270);
            this.btnRegisterBook.Name = "btnRegisterBook";
            this.btnRegisterBook.Size = new System.Drawing.Size(219, 96);
            this.btnRegisterBook.TabIndex = 2;
            this.btnRegisterBook.Text = "Register Book";
            this.btnRegisterBook.UseVisualStyleBackColor = true;
            this.btnRegisterBook.Click += new System.EventHandler(this.btnRegisterBook_Click);
            // 
            // cbxCustomers
            // 
            this.cbxCustomers.FormattingEnabled = true;
            this.cbxCustomers.Location = new System.Drawing.Point(154, 40);
            this.cbxCustomers.Name = "cbxCustomers";
            this.cbxCustomers.Size = new System.Drawing.Size(289, 33);
            this.cbxCustomers.TabIndex = 3;
            // 
            // cbxBooks
            // 
            this.cbxBooks.FormattingEnabled = true;
            this.cbxBooks.Location = new System.Drawing.Point(154, 118);
            this.cbxBooks.Name = "cbxBooks";
            this.cbxBooks.Size = new System.Drawing.Size(289, 33);
            this.cbxBooks.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(143, 187);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(300, 31);
            this.dtpDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbxBooks);
            this.Controls.Add(this.cbxCustomers);
            this.Controls.Add(this.btnRegisterBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "Form1";
            this.Text = "Book Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddCustomer;
        private Button btnAddBook;
        private Button btnRegisterBook;
        private ComboBox cbxCustomers;
        private ComboBox cbxBooks;
        private DateTimePicker dtpDate;
        private Label label1;
        private Label label2;
    }
}
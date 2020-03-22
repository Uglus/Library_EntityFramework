namespace Library_EntityFramework
{
    partial class JournalForm
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
            this.journalList = new System.Windows.Forms.ListView();
            this.JournalId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManagerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.managerBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.readerBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dellBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // journalList
            // 
            this.journalList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JournalId,
            this.BookId,
            this.ManagerId,
            this.ReaderId,
            this.Date1,
            this.Date2});
            this.journalList.HideSelection = false;
            this.journalList.Location = new System.Drawing.Point(12, 12);
            this.journalList.Name = "journalList";
            this.journalList.Size = new System.Drawing.Size(764, 259);
            this.journalList.TabIndex = 0;
            this.journalList.UseCompatibleStateImageBehavior = false;
            this.journalList.View = System.Windows.Forms.View.Details;
            this.journalList.SelectedIndexChanged += new System.EventHandler(this.journalList_SelectedIndexChanged);
            // 
            // JournalId
            // 
            this.JournalId.Text = "Id";
            this.JournalId.Width = 28;
            // 
            // BookId
            // 
            this.BookId.Text = "Book";
            this.BookId.Width = 97;
            // 
            // ManagerId
            // 
            this.ManagerId.Text = "Manager";
            this.ManagerId.Width = 115;
            // 
            // ReaderId
            // 
            this.ReaderId.Text = "Reader";
            this.ReaderId.Width = 143;
            // 
            // Date1
            // 
            this.Date1.Text = "Issue Date";
            this.Date1.Width = 194;
            // 
            // Date2
            // 
            this.Date2.Text = "Return Date";
            this.Date2.Width = 182;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(682, 316);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 36);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(85, 289);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(129, 20);
            this.nameBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Название:";
            // 
            // managerBox
            // 
            this.managerBox.Location = new System.Drawing.Point(85, 325);
            this.managerBox.Name = "managerBox";
            this.managerBox.Size = new System.Drawing.Size(129, 20);
            this.managerBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Manager :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Читатель :";
            // 
            // readerBox
            // 
            this.readerBox.Location = new System.Drawing.Point(85, 362);
            this.readerBox.Name = "readerBox";
            this.readerBox.Size = new System.Drawing.Size(129, 20);
            this.readerBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Issue Date :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(333, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Return Date :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 30;
            // 
            // dellBtn
            // 
            this.dellBtn.Location = new System.Drawing.Point(541, 342);
            this.dellBtn.Name = "dellBtn";
            this.dellBtn.Size = new System.Drawing.Size(90, 36);
            this.dellBtn.TabIndex = 32;
            this.dellBtn.Text = "Удалить";
            this.dellBtn.UseVisualStyleBackColor = true;
            this.dellBtn.Click += new System.EventHandler(this.dellBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(541, 285);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 36);
            this.addBtn.TabIndex = 33;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 397);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dellBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.readerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.managerBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.journalList);
            this.Name = "JournalForm";
            this.Text = "JournalForm";
            this.Load += new System.EventHandler(this.JournalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView journalList;
        private System.Windows.Forms.ColumnHeader JournalId;
        private System.Windows.Forms.ColumnHeader BookId;
        private System.Windows.Forms.ColumnHeader ManagerId;
        private System.Windows.Forms.ColumnHeader ReaderId;
        private System.Windows.Forms.ColumnHeader Date1;
        private System.Windows.Forms.ColumnHeader Date2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox managerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox readerBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dellBtn;
        private System.Windows.Forms.Button addBtn;
    }
}
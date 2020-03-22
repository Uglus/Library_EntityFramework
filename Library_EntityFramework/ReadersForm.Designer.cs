namespace Library_EntityFramework
{
    partial class ReadersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadersForm));
            this.deleteReaderBtn = new System.Windows.Forms.Button();
            this.saveReaderBtn = new System.Windows.Forms.Button();
            this.addReaderBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.readersList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteReaderBtn
            // 
            this.deleteReaderBtn.Location = new System.Drawing.Point(222, 812);
            this.deleteReaderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteReaderBtn.Name = "deleteReaderBtn";
            this.deleteReaderBtn.Size = new System.Drawing.Size(192, 44);
            this.deleteReaderBtn.TabIndex = 23;
            this.deleteReaderBtn.Text = "Удалить";
            this.deleteReaderBtn.UseVisualStyleBackColor = true;
            this.deleteReaderBtn.Click += new System.EventHandler(this.deleteReaderBtn_Click);
            // 
            // saveReaderBtn
            // 
            this.saveReaderBtn.Location = new System.Drawing.Point(436, 812);
            this.saveReaderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveReaderBtn.Name = "saveReaderBtn";
            this.saveReaderBtn.Size = new System.Drawing.Size(192, 44);
            this.saveReaderBtn.TabIndex = 22;
            this.saveReaderBtn.Text = "Сохранить";
            this.saveReaderBtn.UseVisualStyleBackColor = true;
            this.saveReaderBtn.Click += new System.EventHandler(this.saveReaderBtn_Click);
            // 
            // addReaderBtn
            // 
            this.addReaderBtn.Location = new System.Drawing.Point(22, 812);
            this.addReaderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addReaderBtn.Name = "addReaderBtn";
            this.addReaderBtn.Size = new System.Drawing.Size(192, 44);
            this.addReaderBtn.TabIndex = 21;
            this.addReaderBtn.Text = "Добавить";
            this.addReaderBtn.UseVisualStyleBackColor = true;
            this.addReaderBtn.Click += new System.EventHandler(this.addReaderBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 744);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Контакты:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(162, 677);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(600, 31);
            this.nameBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 681);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ф.И.О";
            // 
            // readersList
            // 
            this.readersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader2,
            this.columnHeader1});
            this.readersList.HideSelection = false;
            this.readersList.Location = new System.Drawing.Point(22, 21);
            this.readersList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readersList.Name = "readersList";
            this.readersList.Size = new System.Drawing.Size(820, 294);
            this.readersList.TabIndex = 16;
            this.readersList.UseCompatibleStateImageBehavior = false;
            this.readersList.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 186;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contact";
            this.columnHeader1.Width = 618;
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(162, 738);
            this.contactBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contactBox.Multiline = true;
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(600, 35);
            this.contactBox.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(162, 329);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 312);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 812);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 44);
            this.button1.TabIndex = 26;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 890);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.deleteReaderBtn);
            this.Controls.Add(this.saveReaderBtn);
            this.Controls.Add(this.addReaderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readersList);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ReadersForm";
            this.Text = "ReadersForm";
            this.Load += new System.EventHandler(this.ReadersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteReaderBtn;
        private System.Windows.Forms.Button saveReaderBtn;
        private System.Windows.Forms.Button addReaderBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView readersList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
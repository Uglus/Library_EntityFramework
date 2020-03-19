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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteReaderBtn
            // 
            this.deleteReaderBtn.Location = new System.Drawing.Point(327, 422);
            this.deleteReaderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteReaderBtn.Name = "deleteReaderBtn";
            this.deleteReaderBtn.Size = new System.Drawing.Size(96, 23);
            this.deleteReaderBtn.TabIndex = 23;
            this.deleteReaderBtn.Text = "Удалить";
            this.deleteReaderBtn.UseVisualStyleBackColor = true;
            this.deleteReaderBtn.Click += new System.EventHandler(this.deleteReaderBtn_Click);
            // 
            // saveReaderBtn
            // 
            this.saveReaderBtn.Location = new System.Drawing.Point(163, 422);
            this.saveReaderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveReaderBtn.Name = "saveReaderBtn";
            this.saveReaderBtn.Size = new System.Drawing.Size(96, 23);
            this.saveReaderBtn.TabIndex = 22;
            this.saveReaderBtn.Text = "Сохранить";
            this.saveReaderBtn.UseVisualStyleBackColor = true;
            this.saveReaderBtn.Click += new System.EventHandler(this.saveReaderBtn_Click);
            // 
            // addReaderBtn
            // 
            this.addReaderBtn.Location = new System.Drawing.Point(11, 422);
            this.addReaderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addReaderBtn.Name = "addReaderBtn";
            this.addReaderBtn.Size = new System.Drawing.Size(96, 23);
            this.addReaderBtn.TabIndex = 21;
            this.addReaderBtn.Text = "Добавить";
            this.addReaderBtn.UseVisualStyleBackColor = true;
            this.addReaderBtn.Click += new System.EventHandler(this.addReaderBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Контакты:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(81, 352);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(302, 20);
            this.nameBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
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
            this.readersList.Location = new System.Drawing.Point(11, 11);
            this.readersList.Margin = new System.Windows.Forms.Padding(2);
            this.readersList.Name = "readersList";
            this.readersList.Size = new System.Drawing.Size(412, 155);
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
            this.contactBox.Location = new System.Drawing.Point(81, 384);
            this.contactBox.Margin = new System.Windows.Forms.Padding(2);
            this.contactBox.Multiline = true;
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(302, 20);
            this.contactBox.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(81, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 162);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.deleteReaderBtn);
            this.Controls.Add(this.saveReaderBtn);
            this.Controls.Add(this.addReaderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readersList);
            this.Name = "ReadersForm";
            this.Text = "ReadersForm";
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
    }
}
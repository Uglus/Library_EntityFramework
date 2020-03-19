namespace Library_EntityFramework
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.booksList = new System.Windows.Forms.ListView();
            this.bookId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.bookPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookPages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genreCombo = new System.Windows.Forms.ComboBox();
            this.publisherCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yearNum = new System.Windows.Forms.NumericUpDown();
            this.pagesNum = new System.Windows.Forms.NumericUpDown();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // booksList
            // 
            this.booksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookId,
            this.bookName,
            this.bookGenre,
            this.bookPublisher,
            this.bookYear,
            this.bookPages,
            this.bookPrice});
            this.booksList.HideSelection = false;
            this.booksList.Location = new System.Drawing.Point(12, 12);
            this.booksList.MultiSelect = false;
            this.booksList.Name = "booksList";
            this.booksList.Size = new System.Drawing.Size(410, 211);
            this.booksList.TabIndex = 24;
            this.booksList.UseCompatibleStateImageBehavior = false;
            this.booksList.View = System.Windows.Forms.View.Details;
            this.booksList.SelectedIndexChanged += new System.EventHandler(this.managersList_SelectedIndexChanged);
            // 
            // bookId
            // 
            this.bookId.Text = "Id";
            // 
            // bookName
            // 
            this.bookName.Text = "Название";
            // 
            // bookGenre
            // 
            this.bookGenre.Text = "Жанр";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(305, 415);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(117, 23);
            this.delBtn.TabIndex = 23;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(159, 415);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 23);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Жанр:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(72, 243);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(129, 20);
            this.nameBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 415);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 23);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // bookPublisher
            // 
            this.bookPublisher.Text = "Издатель";
            // 
            // bookYear
            // 
            this.bookYear.Text = "Год";
            // 
            // bookPages
            // 
            this.bookPages.Text = "Страницы";
            // 
            // bookPrice
            // 
            this.bookPrice.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Издатель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Страницы:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Год:";
            // 
            // genreCombo
            // 
            this.genreCombo.FormattingEnabled = true;
            this.genreCombo.Location = new System.Drawing.Point(72, 269);
            this.genreCombo.Name = "genreCombo";
            this.genreCombo.Size = new System.Drawing.Size(129, 21);
            this.genreCombo.TabIndex = 32;
            // 
            // publisherCombo
            // 
            this.publisherCombo.FormattingEnabled = true;
            this.publisherCombo.Location = new System.Drawing.Point(72, 295);
            this.publisherCombo.Name = "publisherCombo";
            this.publisherCombo.Size = new System.Drawing.Size(129, 21);
            this.publisherCombo.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Цена:";
            // 
            // yearNum
            // 
            this.yearNum.Location = new System.Drawing.Point(305, 243);
            this.yearNum.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.yearNum.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.yearNum.Name = "yearNum";
            this.yearNum.Size = new System.Drawing.Size(117, 20);
            this.yearNum.TabIndex = 36;
            this.yearNum.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // pagesNum
            // 
            this.pagesNum.Location = new System.Drawing.Point(305, 269);
            this.pagesNum.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.pagesNum.Name = "pagesNum";
            this.pagesNum.Size = new System.Drawing.Size(117, 20);
            this.pagesNum.TabIndex = 37;
            // 
            // priceNum
            // 
            this.priceNum.Location = new System.Drawing.Point(305, 295);
            this.priceNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(117, 20);
            this.priceNum.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(95, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 82);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.pagesNum);
            this.Controls.Add(this.yearNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.publisherCombo);
            this.Controls.Add(this.genreCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.booksList);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.yearNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView booksList;
        private System.Windows.Forms.ColumnHeader bookId;
        private System.Windows.Forms.ColumnHeader bookName;
        private System.Windows.Forms.ColumnHeader bookGenre;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ColumnHeader bookPublisher;
        private System.Windows.Forms.ColumnHeader bookYear;
        private System.Windows.Forms.ColumnHeader bookPages;
        private System.Windows.Forms.ColumnHeader bookPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox genreCombo;
        private System.Windows.Forms.ComboBox publisherCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown yearNum;
        private System.Windows.Forms.NumericUpDown pagesNum;
        private System.Windows.Forms.NumericUpDown priceNum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace Library_EntityFramework
{
    partial class PublishersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublishersForm));
            this.deletePublisherBtn = new System.Windows.Forms.Button();
            this.savePublisherBtn = new System.Windows.Forms.Button();
            this.addPublisherBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.publishersList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deletePublisherBtn
            // 
            this.deletePublisherBtn.Location = new System.Drawing.Point(304, 408);
            this.deletePublisherBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deletePublisherBtn.Name = "deletePublisherBtn";
            this.deletePublisherBtn.Size = new System.Drawing.Size(96, 23);
            this.deletePublisherBtn.TabIndex = 29;
            this.deletePublisherBtn.Text = "Удалить";
            this.deletePublisherBtn.UseVisualStyleBackColor = true;
            this.deletePublisherBtn.Click += new System.EventHandler(this.deletePublisherBtn_Click);
            // 
            // savePublisherBtn
            // 
            this.savePublisherBtn.Location = new System.Drawing.Point(172, 408);
            this.savePublisherBtn.Margin = new System.Windows.Forms.Padding(2);
            this.savePublisherBtn.Name = "savePublisherBtn";
            this.savePublisherBtn.Size = new System.Drawing.Size(96, 23);
            this.savePublisherBtn.TabIndex = 28;
            this.savePublisherBtn.Text = "Сохранить";
            this.savePublisherBtn.UseVisualStyleBackColor = true;
            this.savePublisherBtn.Click += new System.EventHandler(this.savePublisherBtn_Click);
            // 
            // addPublisherBtn
            // 
            this.addPublisherBtn.Location = new System.Drawing.Point(35, 408);
            this.addPublisherBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addPublisherBtn.Name = "addPublisherBtn";
            this.addPublisherBtn.Size = new System.Drawing.Size(96, 23);
            this.addPublisherBtn.TabIndex = 27;
            this.addPublisherBtn.Text = "Добавить";
            this.addPublisherBtn.UseVisualStyleBackColor = true;
            this.addPublisherBtn.Click += new System.EventHandler(this.addPublisherBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(104, 362);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(273, 20);
            this.nameBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ф.И.О";
            // 
            // publishersList
            // 
            this.publishersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader2});
            this.publishersList.HideSelection = false;
            this.publishersList.Location = new System.Drawing.Point(11, 11);
            this.publishersList.Margin = new System.Windows.Forms.Padding(2);
            this.publishersList.Name = "publishersList";
            this.publishersList.Size = new System.Drawing.Size(412, 177);
            this.publishersList.TabIndex = 24;
            this.publishersList.UseCompatibleStateImageBehavior = false;
            this.publishersList.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 409;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 168);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // PublishersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deletePublisherBtn);
            this.Controls.Add(this.savePublisherBtn);
            this.Controls.Add(this.addPublisherBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publishersList);
            this.Name = "PublishersForm";
            this.Text = "PublishersForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletePublisherBtn;
        private System.Windows.Forms.Button savePublisherBtn;
        private System.Windows.Forms.Button addPublisherBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView publishersList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
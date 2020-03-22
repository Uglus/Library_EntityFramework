namespace Library_EntityFramework
{
    partial class AuthorsForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.authorsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addBtn.Location = new System.Drawing.Point(12, 300);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ф.И.О";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(107, 256);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(216, 20);
            this.nameBox.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.saveBtn.Location = new System.Drawing.Point(155, 300);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.delBtn.Location = new System.Drawing.Point(293, 300);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(117, 23);
            this.delBtn.TabIndex = 7;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // authorsList
            // 
            this.authorsList.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.authorsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.authorsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorsList.FullRowSelect = true;
            this.authorsList.HideSelection = false;
            this.authorsList.Location = new System.Drawing.Point(0, 0);
            this.authorsList.Name = "authorsList";
            this.authorsList.Size = new System.Drawing.Size(425, 229);
            this.authorsList.TabIndex = 0;
            this.authorsList.UseCompatibleStateImageBehavior = false;
            this.authorsList.View = System.Windows.Forms.View.Details;
            this.authorsList.SelectedIndexChanged += new System.EventHandler(this.authorsList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ф.И.О.";
            this.columnHeader2.Width = 330;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_EntityFramework.Properties.Resources.Команда__2_;
            this.pictureBox1.Location = new System.Drawing.Point(315, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(425, 343);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.authorsList);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.ListView authorsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.addReaderBtn = new System.Windows.Forms.Button();
            this.deleteReaderBtn = new System.Windows.Forms.Button();
            this.changeReaderBtn = new System.Windows.Forms.Button();
            this.saveReaderBtn = new System.Windows.Forms.Button();
            this.readersList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addReaderBtn);
            this.panel1.Controls.Add(this.deleteReaderBtn);
            this.panel1.Controls.Add(this.changeReaderBtn);
            this.panel1.Controls.Add(this.saveReaderBtn);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-4, -19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 392);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Library_EntityFramework.Properties.Resources.Команда__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(2, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addReaderBtn
            // 
            this.addReaderBtn.FlatAppearance.BorderSize = 0;
            this.addReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReaderBtn.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addReaderBtn.ForeColor = System.Drawing.Color.Black;
            this.addReaderBtn.Image = ((System.Drawing.Image)(resources.GetObject("addReaderBtn.Image")));
            this.addReaderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addReaderBtn.Location = new System.Drawing.Point(2, 22);
            this.addReaderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addReaderBtn.Name = "addReaderBtn";
            this.addReaderBtn.Size = new System.Drawing.Size(201, 76);
            this.addReaderBtn.TabIndex = 13;
            this.addReaderBtn.Text = "Добавить";
            this.addReaderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addReaderBtn.UseVisualStyleBackColor = true;
            // 
            // deleteReaderBtn
            // 
            this.deleteReaderBtn.FlatAppearance.BorderSize = 0;
            this.deleteReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteReaderBtn.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteReaderBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteReaderBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteReaderBtn.Image")));
            this.deleteReaderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteReaderBtn.Location = new System.Drawing.Point(2, 101);
            this.deleteReaderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteReaderBtn.Name = "deleteReaderBtn";
            this.deleteReaderBtn.Size = new System.Drawing.Size(200, 76);
            this.deleteReaderBtn.TabIndex = 15;
            this.deleteReaderBtn.Text = "Удалить";
            this.deleteReaderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteReaderBtn.UseVisualStyleBackColor = true;
            // 
            // changeReaderBtn
            // 
            this.changeReaderBtn.FlatAppearance.BorderSize = 0;
            this.changeReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeReaderBtn.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeReaderBtn.ForeColor = System.Drawing.Color.Black;
            this.changeReaderBtn.Image = ((System.Drawing.Image)(resources.GetObject("changeReaderBtn.Image")));
            this.changeReaderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeReaderBtn.Location = new System.Drawing.Point(2, 259);
            this.changeReaderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeReaderBtn.Name = "changeReaderBtn";
            this.changeReaderBtn.Size = new System.Drawing.Size(201, 76);
            this.changeReaderBtn.TabIndex = 16;
            this.changeReaderBtn.Text = "Изменить";
            this.changeReaderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeReaderBtn.UseVisualStyleBackColor = true;
            // 
            // saveReaderBtn
            // 
            this.saveReaderBtn.FlatAppearance.BorderSize = 0;
            this.saveReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveReaderBtn.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveReaderBtn.ForeColor = System.Drawing.Color.Black;
            this.saveReaderBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveReaderBtn.Image")));
            this.saveReaderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveReaderBtn.Location = new System.Drawing.Point(4, 180);
            this.saveReaderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveReaderBtn.Name = "saveReaderBtn";
            this.saveReaderBtn.Size = new System.Drawing.Size(198, 76);
            this.saveReaderBtn.TabIndex = 14;
            this.saveReaderBtn.Text = "Сохранить";
            this.saveReaderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveReaderBtn.UseVisualStyleBackColor = true;
            // 
            // readersList
            // 
            this.readersList.BackColor = System.Drawing.Color.Snow;
            this.readersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader2,
            this.columnHeader1});
            this.readersList.Font = new System.Drawing.Font("Courier New", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readersList.ForeColor = System.Drawing.Color.Black;
            this.readersList.HideSelection = false;
            this.readersList.Location = new System.Drawing.Point(200, 3);
            this.readersList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readersList.Name = "readersList";
            this.readersList.Size = new System.Drawing.Size(436, 242);
            this.readersList.TabIndex = 18;
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
            this.columnHeader2.Width = 91;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contact";
            this.columnHeader1.Width = 144;
            // 
            // contactBox
            // 
            this.contactBox.BackColor = System.Drawing.Color.Snow;
            this.contactBox.Location = new System.Drawing.Point(330, 292);
            this.contactBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contactBox.Multiline = true;
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(302, 57);
            this.contactBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(200, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Контакты:";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Snow;
            this.nameBox.Location = new System.Drawing.Point(328, 249);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(302, 24);
            this.nameBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(212, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ф.И.О:";
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(632, 354);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.readersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReadersForm";
            this.Text = "ReadersForm";
            this.Load += new System.EventHandler(this.ReadersForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addReaderBtn;
        private System.Windows.Forms.Button deleteReaderBtn;
        private System.Windows.Forms.Button changeReaderBtn;
        private System.Windows.Forms.Button saveReaderBtn;
        private System.Windows.Forms.ListView readersList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
    }
}
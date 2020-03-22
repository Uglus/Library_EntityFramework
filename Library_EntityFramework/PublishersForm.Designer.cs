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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.changePublisherBtn = new System.Windows.Forms.Button();
            this.addPublisherBtn = new System.Windows.Forms.Button();
            this.savePublisherBtn = new System.Windows.Forms.Button();
            this.deletePublisherBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.publishersList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.changePublisherBtn);
            this.panel1.Controls.Add(this.addPublisherBtn);
            this.panel1.Controls.Add(this.savePublisherBtn);
            this.panel1.Controls.Add(this.deletePublisherBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 317);
            this.panel1.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(4, 267);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 48);
            this.button2.TabIndex = 27;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // changePublisherBtn
            // 
            this.changePublisherBtn.FlatAppearance.BorderSize = 0;
            this.changePublisherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePublisherBtn.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePublisherBtn.ForeColor = System.Drawing.Color.White;
            this.changePublisherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePublisherBtn.Location = new System.Drawing.Point(4, 198);
            this.changePublisherBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changePublisherBtn.Name = "changePublisherBtn";
            this.changePublisherBtn.Size = new System.Drawing.Size(201, 60);
            this.changePublisherBtn.TabIndex = 26;
            this.changePublisherBtn.Text = "Изменить";
            this.changePublisherBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changePublisherBtn.UseVisualStyleBackColor = true;
            this.changePublisherBtn.Click += new System.EventHandler(this.changePublisherBtn_Click_1);
            // 
            // addPublisherBtn
            // 
            this.addPublisherBtn.FlatAppearance.BorderSize = 0;
            this.addPublisherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPublisherBtn.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPublisherBtn.ForeColor = System.Drawing.Color.White;
            this.addPublisherBtn.Location = new System.Drawing.Point(2, 2);
            this.addPublisherBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPublisherBtn.Name = "addPublisherBtn";
            this.addPublisherBtn.Size = new System.Drawing.Size(204, 68);
            this.addPublisherBtn.TabIndex = 21;
            this.addPublisherBtn.Text = "Добавить";
            this.addPublisherBtn.UseVisualStyleBackColor = true;
            // 
            // savePublisherBtn
            // 
            this.savePublisherBtn.FlatAppearance.BorderSize = 0;
            this.savePublisherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePublisherBtn.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePublisherBtn.ForeColor = System.Drawing.Color.White;
            this.savePublisherBtn.Location = new System.Drawing.Point(2, 124);
            this.savePublisherBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savePublisherBtn.Name = "savePublisherBtn";
            this.savePublisherBtn.Size = new System.Drawing.Size(204, 79);
            this.savePublisherBtn.TabIndex = 22;
            this.savePublisherBtn.Text = "Сохранить";
            this.savePublisherBtn.UseVisualStyleBackColor = true;
            // 
            // deletePublisherBtn
            // 
            this.deletePublisherBtn.FlatAppearance.BorderSize = 0;
            this.deletePublisherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePublisherBtn.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePublisherBtn.ForeColor = System.Drawing.Color.White;
            this.deletePublisherBtn.Location = new System.Drawing.Point(2, 63);
            this.deletePublisherBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deletePublisherBtn.Name = "deletePublisherBtn";
            this.deletePublisherBtn.Size = new System.Drawing.Size(204, 70);
            this.deletePublisherBtn.TabIndex = 23;
            this.deletePublisherBtn.Text = "Удалить";
            this.deletePublisherBtn.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(251, 267);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(364, 45);
            this.nameBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ф.И.О";
            // 
            // publishersList
            // 
            this.publishersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader2});
            this.publishersList.HideSelection = false;
            this.publishersList.Location = new System.Drawing.Point(204, 0);
            this.publishersList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.publishersList.Name = "publishersList";
            this.publishersList.Size = new System.Drawing.Size(411, 260);
            this.publishersList.TabIndex = 25;
            this.publishersList.UseCompatibleStateImageBehavior = false;
            this.publishersList.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 409;
            // 
            // PublishersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(618, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publishersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PublishersForm";
            this.Text = "PublishersForm";
            this.Load += new System.EventHandler(this.PublishersForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changePublisherBtn;
        private System.Windows.Forms.Button addPublisherBtn;
        private System.Windows.Forms.Button savePublisherBtn;
        private System.Windows.Forms.Button deletePublisherBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView publishersList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
    }
}
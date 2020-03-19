namespace Library_EntityFramework
{
    partial class ManagersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagersForm));
            this.delBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.contactsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.managersList = new System.Windows.Forms.ListView();
            this.managerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.managerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.managerContacts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(305, 415);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(117, 23);
            this.delBtn.TabIndex = 15;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(159, 415);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 23);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // contactsBox
            // 
            this.contactsBox.Location = new System.Drawing.Point(107, 282);
            this.contactsBox.Multiline = true;
            this.contactsBox.Name = "contactsBox";
            this.contactsBox.Size = new System.Drawing.Size(216, 127);
            this.contactsBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Контакты:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(107, 256);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(216, 20);
            this.nameBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ф.И.О";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 415);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // managersList
            // 
            this.managersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.managerId,
            this.managerName,
            this.managerContacts});
            this.managersList.HideSelection = false;
            this.managersList.Location = new System.Drawing.Point(12, 12);
            this.managersList.Name = "managersList";
            this.managersList.Size = new System.Drawing.Size(410, 211);
            this.managersList.TabIndex = 16;
            this.managersList.UseCompatibleStateImageBehavior = false;
            this.managersList.View = System.Windows.Forms.View.Details;
            this.managersList.SelectedIndexChanged += new System.EventHandler(this.managersList_SelectedIndexChanged);
            // 
            // managerId
            // 
            this.managerId.Text = "Id";
            // 
            // managerName
            // 
            this.managerName.Text = "ФИО";
            // 
            // managerContacts
            // 
            this.managerContacts.Text = "Контакты";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(329, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 127);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.managersList);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.contactsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.DoubleBuffered = true;
            this.Name = "ManagersForm";
            this.Text = "ManagersList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox contactsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListView managersList;
        private System.Windows.Forms.ColumnHeader managerId;
        private System.Windows.Forms.ColumnHeader managerName;
        private System.Windows.Forms.ColumnHeader managerContacts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_EntityFramework
{
    public partial class AuthorsForm : Form
    {
        Database1Entities db = new Database1Entities();

        int k;

        public AuthorsForm()
        {
            InitializeComponent();
            Display();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            db.Authors.Add(new Authors()
            {
                Name = nameBox.Text
            });
            db.SaveChanges();
            Display();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {

            string authorsName = authorsList.SelectedItems[0].SubItems[1].Text;
            Authors authors = db.Authors.FirstOrDefault(a => a.Name == authorsName);
            int authorId = authors.Id;
            foreach (Authors a in db.Authors)
            {
                if (authorId == a.Id)
                {
                    db.Authors.Remove(a);
                }
            }
            db.SaveChanges();
            Display();
        }

        private void Display()
        {
            authorsList.Items.Clear();

            foreach (var i in db.Authors)
            {
                var item = authorsList.Items.Add(i.Id.ToString());
                item.SubItems.Add(i.Name);
            }
        }

        private void authorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                k = authorsList.SelectedIndices[0];
            }
            catch
            {
            }
        }
    }
}

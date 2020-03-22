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
    public partial class PublishersForm : Form
    {
        Database1Entities db;
        public PublishersForm()
        {
            InitializeComponent();
            db = new Database1Entities();
            LoadPublishers();
        }

        public void LoadPublishers()
        {
            publishersList.Items.Clear();
            foreach (Publishers p in db.Publishers)
            {
                var item = publishersList.Items.Add(p.Id.ToString());
                item.SubItems.Add(p.Name);
            }
        }

        private void addPublisherBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Вы не заполнилии Ф.И.О данных!");
            }
            else
            {
                db.Publishers.Add(new Publishers()
                {
                    Name = nameBox.Text
                });
            }
        }

        private void savePublisherBtn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            LoadPublishers();
        }

        private void deletePublisherBtn_Click(object sender, EventArgs e)
        {
            string publisherName = publishersList.SelectedItems[0].SubItems[1].Text;
            Publishers publishersToDelete = db.Publishers.FirstOrDefault(c => c.Name == publisherName);

            db.Publishers.Remove(publishersToDelete);
        }

        private void changePublisherBtn_Click(object sender, EventArgs e)
        {
            string changeName = publishersList.SelectedItems[0].SubItems[1].Text;
            foreach (Publishers p in db.Publishers)
            {
                if (p.Name == changeName)
                {
                    p.Name = nameBox.Text;
                }
            }
            db.SaveChanges();
            LoadPublishers();
        }
    }
}

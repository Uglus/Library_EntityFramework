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
    public partial class ReadersForm : Form
    {
        Database1Entities db;
        public ReadersForm()
        {
            InitializeComponent();
            db = new Database1Entities();
            LoadReaders();
        }

        private void LoadReaders()
        {
            readersList.Items.Clear();
            foreach (Readers r in db.Readers)
            {
                var items = readersList.Items.Add(r.Id.ToString());
                items.SubItems.Add(r.Name);
                items.SubItems.Add(r.Contact);
            }
        }

        private void addReaderBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || contactBox.Text == "")
            {
                MessageBox.Show("Вы не ввели значения!");
            }
            else
            {
                db.Readers.Add(new Readers()
                {
                    Name = nameBox.Text,
                    Contact = contactBox.Text
                });
                db.SaveChanges();
                LoadReaders();
            }
        }

        private void saveReaderBtn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            LoadReaders();
        }

        private void deleteReaderBtn_Click(object sender, EventArgs e)
        {
            string readerName = readersList.SelectedItems[0].SubItems[1].Text;
            MessageBox.Show(readerName);
            Readers readrerToDelete = db.Readers.FirstOrDefault(c => c.Name == readerName);
            int readerId = readrerToDelete.Id;
            foreach (Journal j in db.Journal)
            {
                if (readerId == j.ReaderId)
                {
                    db.Journal.Remove(j);
                }
            }
            db.Readers.Remove(readrerToDelete);
            LoadReaders();
        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            
        }

        private void changeRaedersBtn_Click(object sender, EventArgs e)
        {
            string changeName = readersList.SelectedItems[0].SubItems[1].Text;
            string changeContact = readersList.SelectedItems[0].SubItems[2].Text;
            foreach (Readers r in db.Readers)
            {
                if (r.Name == changeName && r.Contact == changeContact)
                {
                    r.Name = nameBox.Text;
                    r.Contact = contactBox.Text;
                }
            }
            db.SaveChanges();
            LoadReaders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

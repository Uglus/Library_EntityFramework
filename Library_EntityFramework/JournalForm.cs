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
    public partial class JournalForm : Form
    {
        Database1Entities db;
        public JournalForm()
        {
            InitializeComponent();
            db = new Database1Entities();
            LoadJournal();
        }
        public void LoadJournal()
        {
            journalList.Items.Clear();
            foreach (Journal j in db.Journal)
            {
                string bookName = db.Books.FirstOrDefault(b => b.Id == j.BookId).Name;
                string managerName = db.Managers.FirstOrDefault(m => m.Id == j.ManagerId).Name;
                string readerName = db.Readers.FirstOrDefault(r => r.Id == j.ReaderId).Name;

                var item = journalList.Items.Add(j.Id.ToString());
                item.SubItems.Add(bookName);
                item.SubItems.Add(managerName);
                item.SubItems.Add(readerName);
                item.SubItems.Add(j.IssueDate.ToString());
                item.SubItems.Add(j.ReturnDate.ToString());
                
            }
        }

        private void journalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                nameBox.Text = journalList.SelectedItems[0].SubItems[1].Text;
                managerBox.Text = journalList.SelectedItems[0].SubItems[2].Text;
                readerBox.Text = journalList.SelectedItems[0].SubItems[3].Text;
                textBox2.Text = journalList.SelectedItems[0].SubItems[4].Text;
                textBox1.Text = journalList.SelectedItems[0].SubItems[5].Text;
            }
            catch (Exception err)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            LoadJournal();
            MessageBox.Show("Сохранено успешно !","Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dellBtn_Click(object sender, EventArgs e)
        {
            {
                string name = journalList.SelectedItems[0].SubItems[1].Text;
                Books book = db.Books.FirstOrDefault(b => b.Name == name);

                string managername = journalList.SelectedItems[0].SubItems[2].Text;
                Managers manager = db.Managers.FirstOrDefault(m => m.Name == managername);
                int managerId = manager.Id;
                int bookId = book.Id;
                
                foreach (Journal j in db.Journal)
                {
                    if (bookId == j.BookId && managerId == j.ManagerId)
                    {
                        db.Journal.Remove(j);
                    }
                }
                db.SaveChanges();
                LoadJournal();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            NewJournal nj = new NewJournal();

          if ( nj.ShowDialog() == DialogResult.OK)
            {
                LoadJournal();
            }
        }

        private void JournalForm_Load(object sender, EventArgs e)
        {
        
        }

    }
}
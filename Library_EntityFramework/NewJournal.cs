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
    public partial class NewJournal : Form
    {
        Database1Entities db;
        JournalForm jf = new JournalForm();
        public NewJournal()
        {
            InitializeComponent();
            db = new Database1Entities();
            Load1();
        
        }

        private void NewJournal_Load(object sender, EventArgs e)
        {

        }
        private void Load1()
        {
            foreach (var b in db.Books)
                comboBox1.Items.Add(b.Name);

            foreach (var m in db.Managers)
                comboBox3.Items.Add(m.Name);

            foreach (var r in db.Readers)
                comboBox2.Items.Add(r.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {

                string namebook = comboBox1.Text;
                Books book = db.Books.FirstOrDefault(b1 => b1.Name == namebook);

            string namemanager = comboBox3.Text;
                Managers manager = db.Managers.FirstOrDefault(b1 => b1.Name == namemanager);

            string namereader = comboBox2.Text;
                Readers reader = db.Readers.FirstOrDefault(b1 => b1.Name == namereader);
                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;
                DateTime date1 = dt1.Date;
                DateTime date2 = dt2.Date;
            db.Journal.Add(new Journal()
            {
                BookId = book.Id,
                ManagerId = manager.Id,
                ReaderId = reader.Id,
                IssueDate = date1,
                ReturnDate = date2
            }) ;
            db.SaveChanges();
            MessageBox.Show("сохранено !");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

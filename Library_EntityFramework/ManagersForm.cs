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
    public partial class ManagersForm : Form
    {
        Database1Entities db = new Database1Entities();

        public ManagersForm()
        {
            InitializeComponent();
            LoadManagers();
        }

        private void LoadManagers()
        {
            managersList.Items.Clear();
            foreach(Managers m in db.Managers)
            {
                var item = managersList.Items.Add(m.Id.ToString());
                item.SubItems.Add(m.Name);
                item.SubItems.Add(m.Contact);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(nameBox.Text == "" && contactsBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили полей данных!");
            }
            else
            {
                db.Managers.Add(new Managers()
                {
                    Name = nameBox.Text,
                    Contact = contactsBox.Text
                });
            }
           
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string name = managersList.SelectedItems[0].SubItems[1].Text;
            Managers managerToDelete = db.Managers.FirstOrDefault(m => m.Name == name);
            int managerId = managerToDelete.Id;

            foreach (var j in db.Journal)
            {
                if (j.ManagerId == managerId)
                {
                    db.Journal.Remove(j);
                }
            }
            db.Managers.Remove(managerToDelete);        
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string managerName = managersList.SelectedItems[0].SubItems[1].Text;

            foreach (var m in db.Managers)
            {
                if (m.Name == managerName)
                {
                    m.Name = nameBox.Text;
                    m.Contact = contactsBox.Text;
                }
            }

            db.SaveChanges();
            LoadManagers();
        }

        private void managersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameBox.Text = managersList.SelectedItems[0].SubItems[1].Text;
            contactsBox.Text = managersList.SelectedItems[0].SubItems[2].Text;
        }
    }
}

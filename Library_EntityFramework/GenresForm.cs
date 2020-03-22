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
    public partial class GenresForm : Form
    {
        Database1Entities db = new Database1Entities();

        int selected;

        public GenresForm()
        {
            InitializeComponent();
            Display();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            db.Genres.Add(new Genres()
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
            string genreName = genresList.SelectedItems[0].SubItems[1].Text;
            MessageBox.Show(genreName);
            Genres genres = db.Genres.FirstOrDefault(g => g.Name == genreName);
            int genreId = genres.Id;
            foreach (Genres g in db.Genres)
            {
                if (genreId == g.Id)
                {
                    db.Genres.Remove(g);
                }
            }
            db.SaveChanges();
            Display();

        }

        private void Display()
        {
            genresList.Items.Clear();

            foreach (var i in db.Genres)
            {
                var item = genresList.Items.Add(i.Id.ToString());
                item.SubItems.Add(i.Name);
            }
        }

        private void genresList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genresList.SelectedIndices.Count > 0)
            {
                selected = genresList.SelectedIndices[0];
            }
        }
    }
}

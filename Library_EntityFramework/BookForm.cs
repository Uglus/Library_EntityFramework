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
    public partial class BookForm : Form
    {
        Database1Entities db;

        public BookForm()
        {
            InitializeComponent();
            db = new Database1Entities();
            LoadBooks();
        }

        private void LoadBooks()
        {
            booksList.Items.Clear();

            foreach(Books b in db.Books)
            {
                string publisherName = db.Publishers.FirstOrDefault(p => p.Id == b.PublisherId).Name;
                string genreName = db.Genres.FirstOrDefault(g => g.Id == b.GenreId).Name;

                var item = booksList.Items.Add(b.Id.ToString());
                item.SubItems.Add(b.Name);
                item.SubItems.Add(genreName);
                item.SubItems.Add(publisherName);
                item.SubItems.Add(b.Year.ToString());
                item.SubItems.Add(b.Pages.ToString());
                item.SubItems.Add(b.Price.ToString());
            }

            foreach(Publishers p in db.Publishers)
            {
                publisherCombo.Items.Add(p);
                publisherCombo.DisplayMember = p.Name;
            }

            foreach(Genres g in db.Genres)
            {
                genreCombo.Items.Add(g);
                genreCombo.DisplayMember = g.Name;
            }
        }

        private void managersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                nameBox.Text = booksList.SelectedItems[0].SubItems[1].Text;
                publisherCombo.Text = booksList.SelectedItems[0].SubItems[2].Text;
                genreCombo.Text = booksList.SelectedItems[0].SubItems[3].Text;
                yearNum.Value = Convert.ToInt32(booksList.SelectedItems[0].SubItems[4].Text);
                pagesNum.Value = Convert.ToInt32(booksList.SelectedItems[0].SubItems[5].Text);
                priceNum.Value = Convert.ToDecimal(booksList.SelectedItems[0].SubItems[6].Text);
            }
            catch(Exception err)
            {

            }
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int genreId = db.Genres.FirstOrDefault(g => g.Name == genreCombo.Text).Id;
            int publisherId = db.Publishers.FirstOrDefault(p => p.Name == publisherCombo.Text).Id;

            Books book = new Books()
            {
                Name = nameBox.Text,
                GenreId = genreId,
                PublisherId = publisherId,
                Year = (int)yearNum.Value,
                Pages = (int)pagesNum.Value,
                Price = (decimal)priceNum.Value
            };

            db.Books.Add(book);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            LoadBooks();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            int year = (int)yearNum.Value;

            Books book = db.Books.FirstOrDefault
                (b => b.Name == name && b.Year == year);

            db.Books.Remove(book);
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void managersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagersForm mf = new ManagersForm();
            mf.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bf = new BookForm();
            bf.Show();
        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublishersForm pf = new PublishersForm();
            pf.Show();
        }

        private void readersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadersForm rf = new ReadersForm();
            rf.Show();
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenresForm gf = new GenresForm();
            gf.Show();
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorsForm af = new AuthorsForm();
            af.Show();
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalForm jf = new JournalForm();
            jf.Show();
        }
    }
}

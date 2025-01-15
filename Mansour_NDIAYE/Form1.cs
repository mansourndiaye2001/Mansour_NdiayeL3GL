using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mansour_NDIAYE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClasse formClasse = new FormClasse();
            formClasse.Show();
            formClasse.MdiParent = this;
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtudiant form= new FormEtudiant();
            form.Show();
            form.MdiParent = this;
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

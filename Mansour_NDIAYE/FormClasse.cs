using Mansour_NDIAYE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mansour_NDIAYE
{
    public partial class FormClasse : Form

    {
        int idclasse;
        public FormClasse()
        {
            InitializeComponent();
            loadClasse();
        }

        private void FormClasse_Load(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string libelle = txtlibelle.Text;
            using(var db = new  DBScolaireContext())
            {
                Classe classe = new Classe();
                classe.Libelle = libelle;
                db.Classes.Add(classe);
                db.SaveChanges();
                MessageBox.Show("Ajout avec succes");
                loadClasse();

            }

           
        }
        public void loadClasse()
        {
            dataGridView1.DataSource = null;
            using (var db = new DBScolaireContext())
            {
             
                dataGridView1.DataSource = db.Classes.ToList();
               
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            using (var db = new DBScolaireContext())
            {
                Classe classe = db.Classes.FirstOrDefault(c => c.Id == idclasse);
                if (classe !=  null)
                {
                    db.Classes.Remove(classe);

                    db.SaveChanges();
                    loadClasse();
                    MessageBox.Show("Suppression Avec Succes !");

                }

          
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
        
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

              
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[1].Value != null)
                {
                   
                    idclasse = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                    txtlibelle.Text = selectedRow.Cells[1].Value.ToString();
                }
              
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            using (var db = new DBScolaireContext())
            {
                Classe classe = db.Classes.FirstOrDefault(c => c.Id == idclasse);
                if (classe != null)
                {
                    classe.Libelle = txtlibelle.Text;
                  
                    db.SaveChanges();
                    MessageBox.Show("Modification Avec Succes");
                    loadClasse();
                }

              
            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            txtlibelle.Text = " ";

        }
    }
}

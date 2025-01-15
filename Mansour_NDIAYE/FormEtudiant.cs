using Mansour_NDIAYE.Entity;
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
    public partial class FormEtudiant : Form
    {
        int idetudiant;

        public FormEtudiant()
        {
            InitializeComponent();
           
        }

        private void FormEtudiant_Load(object sender, EventArgs e)
        {
            loadclasse();
            loadEtudiants();
        


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = nomtxt.Text;
            string prenom = prenomtxt.Text;
            loadEtudiants();
          

            using (var db = new DBScolaireContext())
            {
                Etudiant etudiant = new Etudiant();
                etudiant.Nom = nom;
                etudiant.Prenom = prenom;
                etudiant.C = (Classe)cmbc.SelectedItem;
              
                db.Etudiants.Add(etudiant);
                db.SaveChanges();
                loadEtudiants();
                MessageBox.Show("Ajout avec Succes !!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new DBScolaireContext())
            {
                Etudiant etudiant = db.Etudiants.FirstOrDefault(c => c.Id == idetudiant);
                if (etudiant != null)
                {
                    db.Etudiants.Remove(etudiant);
                    db.SaveChanges();
                    MessageBox.Show("Suppression avec Suucces !");
                    loadEtudiants();
                }
            }
        }
        public void loadclasse()
        {
            using (var db = new DBScolaireContext())
            {
                cmbc.DataSource = db.Classes.ToList();
                cmbc.DisplayMember = "Libelle";
                cmbc.ValueMember = "id";
                db.SaveChanges();
            }
        }
        public void loadEtudiants()
        {
            dataGridView1.DataSource = null;
            using (var db = new DBScolaireContext())
            {
                dataGridView1.DataSource = db.Etudiants.Select(e => new ViewEtudiant { id = e.Id, nom = e.Nom, prenom = e.Prenom, classe = e.C.Libelle }).ToList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];


                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[1].Value != null)
                {
                    btnmodif.Enabled = true;
                    btnsupp.Enabled = true;
                    bntann.Enabled = true;

                    idetudiant = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                    nomtxt.Text = selectedRow.Cells[1].Value.ToString();
                    prenomtxt.Text = selectedRow.Cells[2].Value.ToString();
                    cmbc.Text = selectedRow.Cells[3].Value.ToString();
                }
                else
                {
                    btnmodif.Enabled = false;
                    btnsupp.Enabled = false;
                    bntann.Enabled = false;
                }

            }
            else
            {
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new DBScolaireContext())
            {
                Etudiant etudiant = db.Etudiants.FirstOrDefault(c => c.Id == idetudiant);
                if (etudiant != null)
                {
                   etudiant.Nom = nomtxt.Text;
                    etudiant.Prenom = prenomtxt.Text;
                    etudiant.C = (Classe)cmbc.SelectedItem;
                    db.SaveChanges();
                    MessageBox.Show("Modification  avec Suucces !");
                    loadEtudiants();
                }

            }
        }
    }
   
  
}

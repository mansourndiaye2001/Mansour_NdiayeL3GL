using Mansour_NDIAYE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansour_NDIAYE.Entity
{
    public  class Etudiant
    {
       
        public int Id { get; set; }
        private int idEtudiant;
        private string nom;
        private string prenom;
        private Classe c;
        private int idclasse;
        public int IdEtudiant { get { return idEtudiant; } set { idEtudiant = value; } }
        public string Nom { get { return nom; }    set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public Classe C { get { return c; } set { c = value; } }
        public int Idclasse { get { return idclasse; } set { int idclasse = value; } }

    }
}
public class ViewEtudiant
{
    public int id { get; set; }
    public string nom { get; set; }
    public string prenom { get; set; }
    public  String  classe { get; set; }
}
using Mansour_NDIAYE.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansour_NDIAYE
{
    internal class DBScolaireContext:DbContext
    {

        public  DBScolaireContext() :base("ecoleconnect") { 
        }
        public DbSet<Classe>Classes { get; set; }
        public DbSet<Etudiant>Etudiants { get; set; }
    }
}

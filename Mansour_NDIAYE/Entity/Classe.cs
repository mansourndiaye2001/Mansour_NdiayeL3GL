using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansour_NDIAYE.Entity
{
    public  class Classe
    {
        [Key]

        public int Id { get; set; }
        private string libelle;
      
        public String Libelle { get { return libelle; } set { libelle = value; } }
    }
}

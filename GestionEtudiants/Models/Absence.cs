using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Absence
    {

        [Key]
        public int id { get; set; }

        [ForeignKey("Etudiant")]
        public Nullable<int> id_etudiant { get; set; }
        public virtual Etudiant Etudiant { get; set; }
        
    }
}

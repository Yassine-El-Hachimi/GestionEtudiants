using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Inscription
    {
        [Key]
        public int id { get; set; }

        [StringLenght(50)]
        public string annee_uni { get; set; }

        [ForeignKey("Filiere")]
        public Nullable<int> id_filiere { get; set; }
        public virtual Filiere Filiere { get; set; }

        public virtual ICollection<Etudiant> etudiants { get; set; }
    }
}

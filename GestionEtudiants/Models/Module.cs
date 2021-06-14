using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Module
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [StringLenght(50)]
        public string nom { get; set; }

        [ForeignKey("Professeur")]
        public Nullable<int> id_professeur { get; set; }
        public virtual Proffesseur Proffesseur { get; set; }

        [ForeignKey("Type")]
        public Nullable<int> id_type { get; set; }
        public virtual Type Type { get; set; }

        public virtual ICollection<Filiere> filieres { get; set; }
        public virtual ICollection<Note> notes { get; set; }
    }
}

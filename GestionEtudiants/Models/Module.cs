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
        public virtual Professeur Professeur { get; set; }



        public virtual ICollection<Filiere> filieres { get; set; }
        public virtual ICollection<Note> notes { get; set; }
    }
}

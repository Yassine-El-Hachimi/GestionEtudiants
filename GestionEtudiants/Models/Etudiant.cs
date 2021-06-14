using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Etudiant
    {
        [Key]
        [Required]
        [StringLenght(50)]
        public int apogee { get; set; }

        [Required]
        [StringLenght(50)]
        public string nom { get; set; }

        [Required]
        [StringLenght(50)]
        public string prenom { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLenght(50)]
        public string email { get; set; }


        [Required]
        [StringLenght(15)]
        public string cin { get; set; }

        [StringLenght(10)]
        public string tel { get; set; }

        [StringLenght(50)]
        public string address { get; set; }

        [ForeignKey("Inscription")]
        public Nullable<int> id_inscription { get; set; }
        public virtual Inscription Inscription { get; set; }


        public virtual ICollection<Absence> absences { get; set; }
        public virtual ICollection<Document> documents { get; set; }

    }
}

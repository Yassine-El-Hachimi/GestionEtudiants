using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Professeur
    {
        

        [Key]
        [Required]
        [StringLenght(50)]
        public int id { get; set; }

        [Required]
        [StringLenght(50)]
        public string nom { get; set; }

        [Required]
        [StringLenght(50)]
        public string prenom { get; set; }

        [StringLenght(50)]
        public string cin { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLenght(50)]
        public string email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLenght(50)]
        public string tel { get; set; }

        [StringLenght(50)]
        public string address { get; set; }

        public virtual ICollection<Module> modules { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Filiere
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [StringLenght(50)]
        public string nom { get; set; }

        public virtual ICollection<Inscription> inscriptions { get; set; }

        public virtual ICollection<Module> modules { get; set; }
    }
}

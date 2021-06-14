using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Type
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [StringLenght(50)]
        public string valeur { get; set; }

        public virtual ICollection<Type> types { get; set; }
    }
}

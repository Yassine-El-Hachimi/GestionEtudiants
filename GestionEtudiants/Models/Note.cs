using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Note
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [StringLenght(50)]
        public string valeur { get; set; }

        [Required]
        [StringLenght(50)]
        public string semestre { get; set; }

        [Required]
        [StringLenght(50)]
        public string evaluation { get; set; }
  

        [ForeignKey("Module")]
        public Nullable<int> id_module { get; set; }
        public virtual Module Module { get; set; }

        [ForeignKey("Type")]
        public Nullable<int> id_type { get; set; }
        public virtual Type Type { get; set; }
    }
}

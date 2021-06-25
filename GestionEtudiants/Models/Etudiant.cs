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

        [StringLenght(50)]
        public String massar { get; set; }

        [StringLenght(50)]
        public String lastname_fr { get; set; }

        [StringLenght(50)]
        public String lastname_ar { get; set; }

        [StringLenght(50)]
        public String firstname_fr { get; set; }

        [StringLenght(50)]
        public String firstname_ar { get; set; }

        [StringLenght(50)]
        public String ddn { get; set; }

        [StringLenght(50)]
        public String ldn { get; set; }

        [StringLenght(50)]
        public String natio { get; set; }

        [StringLenght(50)]
        public String phone { get; set; }

        [StringLenght(50)]
        public String father_name { get; set; }

        [StringLenght(50)]
        public String father_job { get; set; }

        [StringLenght(50)]
        public String mother_name { get; set; }

        [StringLenght(50)]
        public String mother_job { get; set; }

        [StringLenght(50)]
        public String parents_adress { get; set; }

        [StringLenght(50)]
        public String parents_phone { get; set; }

        [StringLenght(50)]
        public String annee { get; set; }

        [StringLenght(50)]
        public String filiere { get; set; }

        [StringLenght(50)]
        public String type_bac { get; set; }

        [StringLenght(50)]
        public String mention_bac { get; set; }

        [StringLenght(50)]
        public String annee_bac { get; set; }

        [StringLenght(50)]
        public String lycee { get; set; }

        [StringLenght(50)]
        public String delegation { get; set; }

        [StringLenght(50)]
        public String academie { get; set; }

        [StringLenght(50)]
        public String diplome { get; set; }

        [StringLenght(50)]
        public String ecole { get; set; }

        [StringLenght(50)]
        public String ville_diplome { get; set; }

        [StringLenght(50)]
        public String picture { get; set; }

        
        public int validated { get; set; }

        [StringLenght(50)]
        public String password { get; set; }
        
        public int code_promo { get; set; }

        [StringLenght(50)]
        public String sexe { get; set; }

        [ForeignKey("Inscription")]
        public Nullable<int> id_inscription { get; set; }
        public virtual Inscription Inscription { get; set; }


        public virtual ICollection<Absence> absences { get; set; }
        public virtual ICollection<Document> documents { get; set; }

    }
}

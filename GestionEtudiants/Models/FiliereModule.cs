using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GestionEtudiants.Models
{
    public class FiliereModule
    {
        public int Id;
        
        [ForeignKey("Filiere")]
        public int FiliereId { get; set; }
        [ForeignKey("Module")]
        public int ModuleId { get; set; }


        public Filiere Filiere { get; set; }
        public Module Module { get; set; }
    }
}

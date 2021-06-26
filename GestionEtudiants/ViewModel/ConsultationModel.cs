using GestionEtudiants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.ViewModel
{
    public class ConsultationModel
    {
        public List<Module> modules { get; set; }
        public List<Professeur> professeurs { get; set; }
        public Dictionary<int,List<Note>> notes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class SchoolDBInitializer
    {
        public List<Filiere> filieres { get; set; }
        public List<Module> modules { get; set; }
        public List<Etudiant> etudiants { get; set; }
        public List<Absence> absences { get; set; }
        public List<Document> documents {get; set;}
        public List<Inscription> inscriptions {get; set;}
        public List<Note> Notes {get; set;}
        public List<Professeur> professeurs{get; set;}
        public List<Type> types {get; set;}



        public SchoolDBInitializer()
        {

            var ids = 1;
            filieres = new List<Filiere>
            {
                new Filiere { id = ids++, nom = "GINFO" },
                new Filiere { id = ids++, nom = "GTR" },
                new Filiere { id = ids++, nom = "GPMC" },
                new Filiere { id = ids++, nom = "GINDUS" }
            };

            ids = 1;
            types = new List<Type>
            {
                new Type { id = ids++, valeur = "DS1" },
                new Type { id = ids++, valeur = "DS2" },
                new Type { id = ids++, valeur = "RAT" },
            };



            /*
            var stock = new Faker<Filiere>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.nom, f => f.Commerce.ProductName())
                .RuleFor(m => m.Category, f => f.Commerce.Categories(1).First())
                .RuleFor(m => m.Price, f => f.Commerce.Price(1).First());
            */
        }

    }
}

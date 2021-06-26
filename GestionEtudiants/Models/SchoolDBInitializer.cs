using Bogus;
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
        public List<Note> notes {get; set;}
        public List<Professeur> professeurs{get; set;}
        public List<Type> types {get; set;}



        public SchoolDBInitializer()
        {

            var docus = new List<String> {
                "A",
                "B",
                "C"
            };


            var ids = 1;
            filieres = new List<Filiere>
            {
                new Filiere { id = ids++, nom = "GINFO" },
                new Filiere { id = ids++, nom = "GTR" },
                new Filiere { id = ids++, nom = "GPMC" },
                new Filiere { id = ids++, nom = "GINDUS"}
            };

            ids = 1;
            types = new List<Type>
            {
                new Type { id = ids++, valeur = "DS1" },
                new Type { id = ids++, valeur = "DS2" },
                new Type { id = ids++, valeur = "RAT" },
            };


            ids = 1;
            var profs = new Faker<Professeur>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.nom, f => f.Person.LastName)
                .RuleFor(m => m.prenom, f => f.Person.FirstName)
                .RuleFor(m => m.tel, f => f.Person.Phone)
                .RuleFor(m => m.address, f => f.Person.Address.ToString())
                .RuleFor(m => m.email, f => f.Person.Email)
                .RuleFor(m => m.cin, f =>  "EE" + f.Random.Number(999999));

            professeurs = profs.Generate(25);


            ids = 1;
            var mods = new Faker<Module>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.nom, f => f.Lorem.Random.Words(3))
                .RuleFor(m => m.id_professeur, f => f.PickRandom(professeurs).id);

            modules = mods.Generate(12);



            ids = 1;
            var nots = new Faker<Note>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.semestre, f => f.Random.Number(2).ToString())
                .RuleFor(m => m.id_module, f => f.PickRandom(modules).id)
                .RuleFor(m => m.id_type, f => f.PickRandom(types).id)
                .RuleFor(m => m.evaluation, f => f.System.Random.Words(1))
                .RuleFor(m => m.valeur, f => f.Random.Number(20).ToString());

            notes = nots.Generate(12);



            ids = 1;
            var inscs = new Faker<Inscription>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.annee_uni, f => "2020/2021")
                .RuleFor(m => m.id_filiere, f => f.PickRandom(filieres).id);

            inscriptions = inscs.Generate(10);



            var iid = 1;
            ids = 2000;
            var etus = new Faker<Etudiant>()
                .RuleFor(m => m.apogee, f => ids++)
                .RuleFor(m => m.nom, f => f.Person.LastName)
                .RuleFor(m => m.prenom, f => f.Person.FirstName)
                .RuleFor(m => m.email, f => f.Person.Email)
                .RuleFor(m => m.cin, f =>  "EE" + f.System.Random.Number(60000))
                .RuleFor(m => m.password, "0000")
                .RuleFor(m => m.sexe, f => f.Person.Gender.ToString())
                .RuleFor(m => m.validated, 1)
                .RuleFor(m => m.id_inscription, f => f.PickRandom(inscriptions).id);

            etudiants = etus.Generate(10);



            ids = 1;
            var abss = new Faker<Absence>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.N_fois, f => f.Random.Number(15))
                .RuleFor(m => m.id_etudiant, f => f.PickRandom(etudiants).apogee);

            absences = abss.Generate(25);


            ids = 1;
            var docs = new Faker<Document>()
                .RuleFor(m => m.id, f => ids++)
                .RuleFor(m => m.type, f => f.PickRandom(docus))
                .RuleFor(m => m.id_etudiant, f => f.PickRandom(etudiants).apogee);

            documents = docs.Generate(75);


        }

    }
}

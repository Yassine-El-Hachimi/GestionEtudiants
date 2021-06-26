using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionEtudiants.Migrations
{
    public partial class ops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filieres",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filieres", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Proffesseurs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proffesseurs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valeur = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Inscriptions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    annee_uni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_filiere = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscriptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Inscriptions_Filieres_id_filiere",
                        column: x => x.id_filiere,
                        principalTable: "Filieres",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_professeur = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.id);
                    table.ForeignKey(
                        name: "FK_Modules_Proffesseurs_id_professeur",
                        column: x => x.id_professeur,
                        principalTable: "Proffesseurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Etudiants",
                columns: table => new
                {
                    apogee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    massar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname_fr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname_ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname_fr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstname_ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ddn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ldn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    natio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    father_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    father_job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mother_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mother_job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parents_adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parents_phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    annee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filiere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type_bac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mention_bac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    annee_bac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lycee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delegation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    academie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diplome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ecole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ville_diplome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    validated = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_inscription = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudiants", x => x.apogee);
                    table.ForeignKey(
                        name: "FK_Etudiants_Inscriptions_id_inscription",
                        column: x => x.id_inscription,
                        principalTable: "Inscriptions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FiliereModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FiliereId = table.Column<int>(type: "int", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiliereModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FiliereModules_Filieres_FiliereId",
                        column: x => x.FiliereId,
                        principalTable: "Filieres",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FiliereModules_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valeur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    semestre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    evaluation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_module = table.Column<int>(type: "int", nullable: true),
                    id_type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Notes_Modules_id_module",
                        column: x => x.id_module,
                        principalTable: "Modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notes_Types_id_type",
                        column: x => x.id_type,
                        principalTable: "Types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Absences",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    N_fois = table.Column<int>(type: "int", nullable: false),
                    id_etudiant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absences", x => x.id);
                    table.ForeignKey(
                        name: "FK_Absences_Etudiants_id_etudiant",
                        column: x => x.id_etudiant,
                        principalTable: "Etudiants",
                        principalColumn: "apogee",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_etudiant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.id);
                    table.ForeignKey(
                        name: "FK_Documents_Etudiants_id_etudiant",
                        column: x => x.id_etudiant,
                        principalTable: "Etudiants",
                        principalColumn: "apogee",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Filieres",
                columns: new[] { "id", "nom" },
                values: new object[,]
                {
                    { 1, "GINFO" },
                    { 2, "GTR" },
                    { 3, "GPMC" },
                    { 4, "GINDUS" }
                });

            migrationBuilder.InsertData(
                table: "Proffesseurs",
                columns: new[] { "id", "address", "cin", "email", "nom", "prenom", "tel" },
                values: new object[,]
                {
                    { 25, "Bogus.Person+CardAddress", "EE901454", "Heather.Leannon@hotmail.com", "Leannon", "Heather", "(604) 581-7525 x19466" },
                    { 24, "Bogus.Person+CardAddress", "EE956597", "Sherry.Pagac@yahoo.com", "Pagac", "Sherry", "755-251-8975" },
                    { 23, "Bogus.Person+CardAddress", "EE458601", "Willie7@yahoo.com", "Douglas", "Willie", "906.949.5940" },
                    { 22, "Bogus.Person+CardAddress", "EE180197", "Lawrence94@hotmail.com", "Kuvalis", "Lawrence", "505.405.3419 x8823" },
                    { 21, "Bogus.Person+CardAddress", "EE625741", "Roxanne_Kiehn@hotmail.com", "Kiehn", "Roxanne", "(248) 901-2008 x45370" },
                    { 20, "Bogus.Person+CardAddress", "EE171407", "Silvia.Kunze@hotmail.com", "Kunze", "Silvia", "(827) 406-7784 x422" },
                    { 19, "Bogus.Person+CardAddress", "EE643092", "Ben83@hotmail.com", "Cremin", "Ben", "689.231.2312" },
                    { 18, "Bogus.Person+CardAddress", "EE108048", "Sabrina67@yahoo.com", "Gerlach", "Sabrina", "475.895.0797 x130" },
                    { 17, "Bogus.Person+CardAddress", "EE183659", "Kelli.OConner@gmail.com", "O'Conner", "Kelli", "681.909.4695 x001" },
                    { 16, "Bogus.Person+CardAddress", "EE13183", "Roy63@gmail.com", "Parker", "Roy", "1-868-394-8100" },
                    { 15, "Bogus.Person+CardAddress", "EE347967", "Darlene_Konopelski14@hotmail.com", "Konopelski", "Darlene", "773-856-7808 x4427" },
                    { 14, "Bogus.Person+CardAddress", "EE983883", "Phillip96@hotmail.com", "Marks", "Phillip", "374-417-5964 x280" },
                    { 12, "Bogus.Person+CardAddress", "EE898851", "Lucas.Kovacek91@hotmail.com", "Kovacek", "Lucas", "613-934-8295 x41143" },
                    { 11, "Bogus.Person+CardAddress", "EE114855", "Krista72@yahoo.com", "Bruen", "Krista", "959-445-9453" },
                    { 10, "Bogus.Person+CardAddress", "EE52484", "Terence28@yahoo.com", "Lynch", "Terence", "1-297-663-7980" },
                    { 9, "Bogus.Person+CardAddress", "EE815580", "Rene61@yahoo.com", "Bins", "Rene", "633-952-3346 x6017" },
                    { 8, "Bogus.Person+CardAddress", "EE47803", "Jackie.Jakubowski@gmail.com", "Jakubowski", "Jackie", "1-672-892-2035 x985" },
                    { 7, "Bogus.Person+CardAddress", "EE52628", "Emma74@gmail.com", "Dooley", "Emma", "413.609.0609" },
                    { 6, "Bogus.Person+CardAddress", "EE311356", "Shelley_Muller33@gmail.com", "Muller", "Shelley", "1-591-510-2932 x8751" },
                    { 5, "Bogus.Person+CardAddress", "EE444675", "Kenneth.Kub@hotmail.com", "Kub", "Kenneth", "798-217-0453 x25460" },
                    { 4, "Bogus.Person+CardAddress", "EE451528", "Tyrone14@hotmail.com", "Bahringer", "Tyrone", "1-798-699-5942 x85156" },
                    { 3, "Bogus.Person+CardAddress", "EE382781", "Roxanne.Welch@hotmail.com", "Welch", "Roxanne", "692.839.1222" },
                    { 2, "Bogus.Person+CardAddress", "EE315928", "Troy_Howe@gmail.com", "Howe", "Troy", "1-319-432-2020" },
                    { 1, "Bogus.Person+CardAddress", "EE345121", "Albert.Pacocha@hotmail.com", "Pacocha", "Albert", "(320) 406-7248 x131" },
                    { 13, "Bogus.Person+CardAddress", "EE257235", "Melvin_Homenick7@gmail.com", "Homenick", "Melvin", "740.808.8061 x36418" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "id", "valeur" },
                values: new object[,]
                {
                    { 2, "DS2" },
                    { 1, "DS1" },
                    { 3, "RAT" }
                });

            migrationBuilder.InsertData(
                table: "Inscriptions",
                columns: new[] { "id", "annee_uni", "id_filiere" },
                values: new object[,]
                {
                    { 4, "2020/2021", 1 },
                    { 7, "2020/2021", 1 },
                    { 9, "2020/2021", 2 },
                    { 1, "2020/2021", 3 },
                    { 5, "2020/2021", 3 },
                    { 10, "2020/2021", 3 },
                    { 2, "2020/2021", 4 },
                    { 3, "2020/2021", 4 },
                    { 6, "2020/2021", 4 },
                    { 8, "2020/2021", 4 }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "id", "id_professeur", "nom" },
                values: new object[,]
                {
                    { 9, 15, "Kids & Games markets Unbranded Plastic Fish" },
                    { 12, 14, "Iraqi Dinar Program upward-trending" },
                    { 6, 12, "Handmade silver JSON" },
                    { 1, 12, "Ergonomic Fresh Bacon website New York" },
                    { 4, 10, "Assistant PCI eyeballs" },
                    { 7, 1, "customized Communications payment" },
                    { 10, 8, "California deposit Loop" },
                    { 5, 8, "copy orchid recontextualize" },
                    { 3, 5, "bus Investment Account orange" },
                    { 11, 19, "deliverables invoice Legacy" },
                    { 2, 10, "compressing Guinea-Bissau Operations" },
                    { 8, 23, "compressing Assurance programming" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "academie", "address", "annee", "annee_bac", "cin", "ddn", "delegation", "diplome", "ecole", "email", "father_job", "father_name", "filiere", "firstname_ar", "firstname_fr", "id_inscription", "lastname_ar", "lastname_fr", "ldn", "lycee", "massar", "mention_bac", "mother_job", "mother_name", "natio", "nom", "parents_adress", "parents_phone", "password", "phone", "picture", "prenom", "sexe", "tel", "type_bac", "validated", "ville_diplome" },
                values: new object[,]
                {
                    { 2001, null, null, null, null, "EE58834", null, null, null, null, "Chelsea_Zemlak@gmail.com", null, null, null, null, null, 4, null, null, null, null, null, null, null, null, null, "Zemlak", null, null, "0000", null, null, "Chelsea", "Female", null, null, 1, null },
                    { 2003, null, null, null, null, "EE24228", null, null, null, null, "Roberta_Williamson@yahoo.com", null, null, null, null, null, 6, null, null, null, null, null, null, null, null, null, "Williamson", null, null, "0000", null, null, "Roberta", "Female", null, null, 1, null },
                    { 2007, null, null, null, null, "EE19201", null, null, null, null, "Sonya.Botsford@gmail.com", null, null, null, null, null, 3, null, null, null, null, null, null, null, null, null, "Botsford", null, null, "0000", null, null, "Sonya", "Female", null, null, 1, null },
                    { 2009, null, null, null, null, "EE59426", null, null, null, null, "Connie_Osinski@yahoo.com", null, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "Osinski", null, null, "0000", null, null, "Connie", "Female", null, null, 1, null },
                    { 2004, null, null, null, null, "EE34030", null, null, null, null, "Nichole_Schmitt@gmail.com", null, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "Schmitt", null, null, "0000", null, null, "Nichole", "Female", null, null, 1, null },
                    { 2000, null, null, null, null, "EE6406", null, null, null, null, "Antoinette_Fahey@yahoo.com", null, null, null, null, null, 6, null, null, null, null, null, null, null, null, null, "Fahey", null, null, "0000", null, null, "Antoinette", "Female", null, null, 1, null },
                    { 2005, null, null, null, null, "EE35969", null, null, null, null, "Minnie_Langosh66@yahoo.com", null, null, null, null, null, 5, null, null, null, null, null, null, null, null, null, "Langosh", null, null, "0000", null, null, "Minnie", "Female", null, null, 1, null },
                    { 2002, null, null, null, null, "EE39510", null, null, null, null, "Molly_Bruen@gmail.com", null, null, null, null, null, 1, null, null, null, null, null, null, null, null, null, "Bruen", null, null, "0000", null, null, "Molly", "Female", null, null, 1, null },
                    { 2008, null, null, null, null, "EE53330", null, null, null, null, "Delia.Lueilwitz86@yahoo.com", null, null, null, null, null, 9, null, null, null, null, null, null, null, null, null, "Lueilwitz", null, null, "0000", null, null, "Delia", "Female", null, null, 1, null },
                    { 2006, null, null, null, null, "EE43268", null, null, null, null, "Wallace49@yahoo.com", null, null, null, null, null, 10, null, null, null, null, null, null, null, null, null, "Langosh", null, null, "0000", null, null, "Wallace", "Male", null, null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "FiliereModules",
                columns: new[] { "Id", "FiliereId", "ModuleId" },
                values: new object[,]
                {
                    { 5, 4, 10 },
                    { 14, 3, 9 },
                    { 11, 1, 2 },
                    { 7, 1, 2 },
                    { 16, 3, 10 },
                    { 6, 3, 10 },
                    { 10, 3, 8 },
                    { 12, 2, 6 },
                    { 2, 1, 5 },
                    { 1, 2, 5 },
                    { 4, 4, 12 },
                    { 8, 2, 3 },
                    { 15, 1, 7 },
                    { 9, 4, 7 },
                    { 3, 4, 7 },
                    { 13, 4, 11 }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "id", "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[,]
                {
                    { 8, "Money Market Account", 9, 3, "0", "0" },
                    { 5, "Fresh", 9, 3, "1", "0" },
                    { 2, "e-markets", 11, 2, "1", "4" },
                    { 4, "Gorgeous Steel Hat", 5, 2, "1", "17" },
                    { 6, "payment", 1, 2, "2", "16" },
                    { 11, "Massachusetts", 4, 2, "0", "0" },
                    { 3, "synergistic", 2, 2, "0", "17" },
                    { 12, "Principal", 10, 3, "1", "17" },
                    { 1, "local area network", 5, 1, "0", "17" },
                    { 9, "Belgium", 3, 3, "0", "19" },
                    { 10, "system", 1, 3, "0", "15" },
                    { 7, "Louisiana", 8, 3, "2", "5" }
                });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "id", "N_fois", "id_etudiant" },
                values: new object[,]
                {
                    { 4, 5, 2001 },
                    { 2, 13, 2005 },
                    { 5, 7, 2005 },
                    { 17, 4, 2005 },
                    { 23, 2, 2007 },
                    { 3, 14, 2006 },
                    { 9, 0, 2006 },
                    { 1, 10, 2000 },
                    { 11, 1, 2006 },
                    { 20, 3, 2006 },
                    { 21, 3, 2007 },
                    { 8, 1, 2007 },
                    { 25, 1, 2009 },
                    { 24, 9, 2009 },
                    { 19, 8, 2004 },
                    { 15, 1, 2006 },
                    { 14, 1, 2000 },
                    { 16, 4, 2005 },
                    { 7, 2, 2008 },
                    { 10, 15, 2001 },
                    { 18, 9, 2001 },
                    { 13, 6, 2008 },
                    { 6, 4, 2003 },
                    { 12, 9, 2002 },
                    { 22, 14, 2003 }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "id", "id_etudiant", "type" },
                values: new object[,]
                {
                    { 69, 2000, "B" },
                    { 56, 2003, "C" },
                    { 59, 2009, "A" },
                    { 46, 2009, "B" },
                    { 40, 2009, "A" },
                    { 26, 2009, "B" },
                    { 23, 2009, "A" },
                    { 10, 2009, "A" },
                    { 3, 2009, "A" },
                    { 60, 2003, "B" },
                    { 74, 2004, "B" },
                    { 66, 2004, "A" },
                    { 35, 2009, "C" },
                    { 55, 2003, "C" },
                    { 12, 2003, "B" },
                    { 13, 2003, "C" },
                    { 57, 2000, "B" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "id", "id_etudiant", "type" },
                values: new object[,]
                {
                    { 53, 2000, "A" },
                    { 34, 2000, "B" },
                    { 5, 2000, "A" },
                    { 1, 2000, "C" },
                    { 70, 2000, "B" },
                    { 43, 2003, "A" },
                    { 71, 2000, "B" },
                    { 48, 2004, "B" },
                    { 65, 2007, "A" },
                    { 47, 2007, "B" },
                    { 44, 2007, "B" },
                    { 8, 2007, "A" },
                    { 6, 2003, "B" },
                    { 72, 2000, "C" },
                    { 38, 2004, "A" },
                    { 42, 2006, "A" },
                    { 32, 2004, "B" },
                    { 39, 2002, "A" },
                    { 31, 2002, "A" },
                    { 28, 2002, "C" },
                    { 18, 2002, "C" },
                    { 14, 2002, "C" },
                    { 75, 2008, "C" },
                    { 49, 2008, "A" },
                    { 21, 2008, "C" },
                    { 7, 2008, "A" },
                    { 2, 2008, "C" },
                    { 68, 2001, "B" },
                    { 52, 2001, "A" },
                    { 27, 2001, "C" },
                    { 24, 2001, "B" },
                    { 22, 2001, "A" },
                    { 17, 2001, "C" },
                    { 16, 2001, "A" },
                    { 54, 2002, "C" },
                    { 62, 2002, "B" },
                    { 73, 2002, "C" },
                    { 37, 2005, "A" },
                    { 25, 2004, "A" },
                    { 19, 2004, "B" },
                    { 50, 2006, "B" },
                    { 45, 2006, "B" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "id", "id_etudiant", "type" },
                values: new object[,]
                {
                    { 63, 2003, "B" },
                    { 41, 2006, "C" },
                    { 36, 2006, "A" },
                    { 30, 2006, "C" },
                    { 33, 2004, "C" },
                    { 29, 2006, "B" },
                    { 15, 2006, "A" },
                    { 11, 2006, "A" },
                    { 9, 2006, "A" },
                    { 4, 2006, "B" },
                    { 67, 2005, "C" },
                    { 61, 2005, "A" },
                    { 58, 2005, "C" },
                    { 51, 2005, "B" },
                    { 20, 2006, "B" },
                    { 64, 2003, "A" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Absences_id_etudiant",
                table: "Absences",
                column: "id_etudiant");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_id_etudiant",
                table: "Documents",
                column: "id_etudiant");

            migrationBuilder.CreateIndex(
                name: "IX_Etudiants_id_inscription",
                table: "Etudiants",
                column: "id_inscription");

            migrationBuilder.CreateIndex(
                name: "IX_FiliereModules_FiliereId",
                table: "FiliereModules",
                column: "FiliereId");

            migrationBuilder.CreateIndex(
                name: "IX_FiliereModules_ModuleId",
                table: "FiliereModules",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscriptions_id_filiere",
                table: "Inscriptions",
                column: "id_filiere");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_id_professeur",
                table: "Modules",
                column: "id_professeur");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_id_module",
                table: "Notes",
                column: "id_module");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_id_type",
                table: "Notes",
                column: "id_type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absences");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "FiliereModules");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Etudiants");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Inscriptions");

            migrationBuilder.DropTable(
                name: "Proffesseurs");

            migrationBuilder.DropTable(
                name: "Filieres");
        }
    }
}

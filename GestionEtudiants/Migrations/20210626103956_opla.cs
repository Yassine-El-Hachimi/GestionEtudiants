using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionEtudiants.Migrations
{
    public partial class opla : Migration
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
                name: "FiliereModule",
                columns: table => new
                {
                    filieresid = table.Column<int>(type: "int", nullable: false),
                    modulesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiliereModule", x => new { x.filieresid, x.modulesid });
                    table.ForeignKey(
                        name: "FK_FiliereModule_Filieres_filieresid",
                        column: x => x.filieresid,
                        principalTable: "Filieres",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FiliereModule_Modules_modulesid",
                        column: x => x.modulesid,
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
                    { 25, "Bogus.Person+CardAddress", "EE649313", "Todd.Reichert30@yahoo.com", "Reichert", "Todd", "822.432.1798" },
                    { 24, "Bogus.Person+CardAddress", "EE839643", "Chad_Weimann@gmail.com", "Weimann", "Chad", "(497) 750-3754 x714" },
                    { 23, "Bogus.Person+CardAddress", "EE267342", "Marie.Baumbach15@gmail.com", "Baumbach", "Marie", "1-466-716-0981" },
                    { 22, "Bogus.Person+CardAddress", "EE355168", "Dave_Streich11@yahoo.com", "Streich", "Dave", "(317) 905-9691" },
                    { 21, "Bogus.Person+CardAddress", "EE689398", "William31@gmail.com", "Pacocha", "William", "333.265.2510" },
                    { 20, "Bogus.Person+CardAddress", "EE296997", "Lee10@yahoo.com", "Kemmer", "Lee", "394.416.1053 x41285" },
                    { 19, "Bogus.Person+CardAddress", "EE614681", "Horace_Deckow@gmail.com", "Deckow", "Horace", "810.454.4360 x9567" },
                    { 18, "Bogus.Person+CardAddress", "EE958236", "Maxine_Morar@gmail.com", "Morar", "Maxine", "(307) 815-7865" },
                    { 17, "Bogus.Person+CardAddress", "EE65235", "Crystal_Goodwin35@hotmail.com", "Goodwin", "Crystal", "482.798.6181 x95600" },
                    { 16, "Bogus.Person+CardAddress", "EE576798", "Deborah14@gmail.com", "Auer", "Deborah", "(645) 686-6875" },
                    { 15, "Bogus.Person+CardAddress", "EE208017", "Lynda81@gmail.com", "Botsford", "Lynda", "(364) 786-0002" },
                    { 14, "Bogus.Person+CardAddress", "EE261329", "Tomas47@gmail.com", "Franecki", "Tomas", "1-768-271-8560" },
                    { 12, "Bogus.Person+CardAddress", "EE499991", "Tasha_Sipes@yahoo.com", "Sipes", "Tasha", "(690) 825-3181 x82636" },
                    { 11, "Bogus.Person+CardAddress", "EE397633", "Raquel_Casper@gmail.com", "Casper", "Raquel", "(721) 903-5625 x66101" },
                    { 10, "Bogus.Person+CardAddress", "EE789015", "Kari80@hotmail.com", "Nader", "Kari", "928.605.4762" },
                    { 9, "Bogus.Person+CardAddress", "EE969188", "Ana.Kemmer93@gmail.com", "Kemmer", "Ana", "1-482-423-4818 x61007" },
                    { 8, "Bogus.Person+CardAddress", "EE859833", "Zachary_Wintheiser35@hotmail.com", "Wintheiser", "Zachary", "303-637-5532 x7676" },
                    { 7, "Bogus.Person+CardAddress", "EE939118", "Julian.Pouros@gmail.com", "Pouros", "Julian", "675.759.3271 x3574" },
                    { 6, "Bogus.Person+CardAddress", "EE174914", "Mae.Dach59@yahoo.com", "Dach", "Mae", "1-617-495-3177" },
                    { 5, "Bogus.Person+CardAddress", "EE254001", "Colin47@hotmail.com", "Baumbach", "Colin", "215.243.8707 x1048" },
                    { 4, "Bogus.Person+CardAddress", "EE974492", "Blake60@gmail.com", "Baumbach", "Blake", "878-637-6505" },
                    { 3, "Bogus.Person+CardAddress", "EE772121", "Geraldine.Corkery17@gmail.com", "Corkery", "Geraldine", "704.875.8925" },
                    { 2, "Bogus.Person+CardAddress", "EE489766", "Owen_Davis94@hotmail.com", "Davis", "Owen", "626.963.8857 x001" },
                    { 1, "Bogus.Person+CardAddress", "EE779357", "Sandra_King@yahoo.com", "King", "Sandra", "1-583-633-6062 x59144" },
                    { 13, "Bogus.Person+CardAddress", "EE761665", "Eunice_Bednar34@gmail.com", "Bednar", "Eunice", "(562) 240-0313 x673" }
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
                    { 2, "2020/2021", 1 },
                    { 7, "2020/2021", 1 },
                    { 1, "2020/2021", 2 },
                    { 3, "2020/2021", 2 },
                    { 6, "2020/2021", 2 },
                    { 9, "2020/2021", 2 },
                    { 4, "2020/2021", 3 },
                    { 5, "2020/2021", 3 },
                    { 8, "2020/2021", 3 },
                    { 10, "2020/2021", 4 }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "id", "id_professeur", "nom" },
                values: new object[,]
                {
                    { 7, 22, "Savings Account quantifying Mississippi" },
                    { 8, 21, "Ferry Expressway Investment Account" },
                    { 4, 15, "approach Garden, Automotive & Electronics Throughway" },
                    { 6, 10, "Incredible application Forint" },
                    { 10, 6, "quantifying Personal Loan Account generate" },
                    { 2, 1, "array Groves Frozen" },
                    { 11, 5, "Berkshire Pass alarm" },
                    { 5, 4, "Garden 24/365 Phased" },
                    { 1, 4, "Buckinghamshire Plains Organic" },
                    { 9, 22, "THX Corporate Cambridgeshire" },
                    { 3, 6, "Grass-roots withdrawal back-end" },
                    { 12, 23, "Ergonomic Rubber Chair models HTTP" }
                });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "apogee", "academie", "address", "annee", "annee_bac", "cin", "ddn", "delegation", "diplome", "ecole", "email", "father_job", "father_name", "filiere", "firstname_ar", "firstname_fr", "id_inscription", "lastname_ar", "lastname_fr", "ldn", "lycee", "massar", "mention_bac", "mother_job", "mother_name", "natio", "nom", "parents_adress", "parents_phone", "password", "phone", "picture", "prenom", "sexe", "tel", "type_bac", "validated", "ville_diplome" },
                values: new object[,]
                {
                    { 2009, null, null, null, null, "EE32226", null, null, null, null, "Terry.Mueller92@yahoo.com", null, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "Mueller", null, null, "0000", null, null, "Terry", "Male", null, null, 1, null },
                    { 2003, null, null, null, null, "EE34458", null, null, null, null, "Laurie_Kovacek66@hotmail.com", null, null, null, null, null, 1, null, null, null, null, null, null, null, null, null, "Kovacek", null, null, "0000", null, null, "Laurie", "Female", null, null, 1, null },
                    { 2006, null, null, null, null, "EE30125", null, null, null, null, "Kurt54@hotmail.com", null, null, null, null, null, 3, null, null, null, null, null, null, null, null, null, "Brekke", null, null, "0000", null, null, "Kurt", "Male", null, null, 1, null },
                    { 2008, null, null, null, null, "EE109", null, null, null, null, "Regina.Harris9@hotmail.com", null, null, null, null, null, 6, null, null, null, null, null, null, null, null, null, "Harris", null, null, "0000", null, null, "Regina", "Female", null, null, 1, null },
                    { 2001, null, null, null, null, "EE20610", null, null, null, null, "Victor.Fadel98@yahoo.com", null, null, null, null, null, 9, null, null, null, null, null, null, null, null, null, "Fadel", null, null, "0000", null, null, "Victor", "Male", null, null, 1, null },
                    { 2005, null, null, null, null, "EE46732", null, null, null, null, "Brad.Keeling@yahoo.com", null, null, null, null, null, 9, null, null, null, null, null, null, null, null, null, "Keeling", null, null, "0000", null, null, "Brad", "Male", null, null, 1, null },
                    { 2007, null, null, null, null, "EE33772", null, null, null, null, "Stuart10@hotmail.com", null, null, null, null, null, 9, null, null, null, null, null, null, null, null, null, "Harvey", null, null, "0000", null, null, "Stuart", "Male", null, null, 1, null },
                    { 2002, null, null, null, null, "EE59037", null, null, null, null, "Terry69@yahoo.com", null, null, null, null, null, 4, null, null, null, null, null, null, null, null, null, "Powlowski", null, null, "0000", null, null, "Terry", "Male", null, null, 1, null },
                    { 2000, null, null, null, null, "EE30565", null, null, null, null, "Katherine.Feest@hotmail.com", null, null, null, null, null, 5, null, null, null, null, null, null, null, null, null, "Feest", null, null, "0000", null, null, "Katherine", "Female", null, null, 1, null },
                    { 2004, null, null, null, null, "EE6013", null, null, null, null, "Stewart72@yahoo.com", null, null, null, null, null, 8, null, null, null, null, null, null, null, null, null, "Roob", null, null, "0000", null, null, "Stewart", "Male", null, null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "id", "evaluation", "id_module", "id_type", "semestre", "valeur" },
                values: new object[,]
                {
                    { 2, "Borders", 8, 1, "2", "16" },
                    { 1, "conglomeration", 8, 1, "0", "14" },
                    { 12, "Pakistan Rupee", 4, 1, "2", "6" },
                    { 8, "e-markets", 4, 1, "1", "18" },
                    { 9, "Handmade Concrete Salad", 3, 2, "2", "12" },
                    { 11, "Western Sahara", 2, 1, "1", "16" },
                    { 3, "solid state", 3, 2, "1", "13" },
                    { 4, "Personal Loan Account", 11, 3, "0", "16" },
                    { 10, "Avon", 5, 2, "2", "9" },
                    { 5, "enable", 9, 2, "1", "1" },
                    { 7, "quantify", 3, 1, "1", "17" },
                    { 6, "index", 12, 3, "0", "7" }
                });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "id", "N_fois", "id_etudiant" },
                values: new object[,]
                {
                    { 2, 2, 2009 },
                    { 5, 13, 2006 },
                    { 6, 8, 2006 },
                    { 9, 13, 2006 },
                    { 23, 14, 2001 },
                    { 22, 5, 2007 },
                    { 18, 3, 2007 },
                    { 15, 13, 2007 },
                    { 11, 10, 2007 },
                    { 1, 13, 2007 },
                    { 20, 3, 2005 },
                    { 17, 6, 2005 },
                    { 16, 13, 2005 },
                    { 14, 4, 2005 },
                    { 3, 0, 2005 },
                    { 4, 3, 2001 },
                    { 7, 2, 2002 },
                    { 13, 9, 2002 },
                    { 25, 14, 2001 },
                    { 21, 15, 2004 },
                    { 8, 1, 2009 },
                    { 12, 5, 2003 },
                    { 24, 15, 2003 },
                    { 19, 2, 2000 },
                    { 10, 2, 2009 }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "id", "id_etudiant", "type" },
                values: new object[,]
                {
                    { 56, 2005, "A" },
                    { 28, 2005, "B" },
                    { 14, 2005, "B" },
                    { 55, 2000, "C" },
                    { 10, 2002, "A" },
                    { 58, 2005, "B" },
                    { 15, 2004, "B" },
                    { 46, 2001, "A" },
                    { 41, 2001, "A" },
                    { 20, 2001, "C" },
                    { 61, 2000, "C" },
                    { 66, 2005, "A" },
                    { 39, 2000, "A" },
                    { 23, 2002, "A" },
                    { 35, 2000, "C" },
                    { 7, 2000, "B" },
                    { 4, 2007, "B" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "id", "id_etudiant", "type" },
                values: new object[,]
                {
                    { 6, 2007, "A" },
                    { 18, 2007, "B" },
                    { 31, 2007, "B" },
                    { 40, 2007, "B" },
                    { 3, 2000, "B" },
                    { 1, 2000, "B" },
                    { 72, 2002, "A" },
                    { 69, 2007, "B" },
                    { 65, 2002, "B" },
                    { 24, 2002, "A" },
                    { 67, 2005, "A" },
                    { 60, 2007, "B" },
                    { 62, 2008, "B" },
                    { 70, 2008, "A" },
                    { 2, 2006, "A" },
                    { 74, 2003, "A" },
                    { 71, 2003, "A" },
                    { 63, 2003, "C" },
                    { 54, 2003, "C" },
                    { 38, 2003, "C" },
                    { 36, 2003, "B" },
                    { 30, 2003, "B" },
                    { 29, 2003, "B" },
                    { 26, 2003, "C" },
                    { 22, 2003, "B" },
                    { 21, 2003, "B" },
                    { 75, 2009, "A" },
                    { 64, 2009, "A" },
                    { 57, 2009, "C" },
                    { 44, 2009, "B" },
                    { 37, 2009, "B" },
                    { 32, 2009, "A" },
                    { 8, 2009, "C" },
                    { 9, 2006, "A" },
                    { 13, 2001, "C" },
                    { 12, 2006, "B" },
                    { 27, 2006, "A" },
                    { 33, 2004, "B" },
                    { 52, 2008, "B" },
                    { 50, 2008, "C" },
                    { 45, 2008, "A" },
                    { 43, 2008, "B" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "id", "id_etudiant", "type" },
                values: new object[,]
                {
                    { 25, 2008, "C" },
                    { 19, 2008, "B" },
                    { 16, 2008, "A" },
                    { 11, 2008, "C" },
                    { 5, 2008, "B" },
                    { 73, 2006, "B" },
                    { 68, 2006, "B" },
                    { 59, 2006, "A" },
                    { 53, 2006, "B" },
                    { 49, 2006, "A" },
                    { 48, 2006, "B" },
                    { 47, 2006, "A" },
                    { 42, 2006, "B" },
                    { 34, 2006, "A" },
                    { 17, 2006, "B" },
                    { 51, 2004, "A" }
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
                name: "IX_FiliereModule_modulesid",
                table: "FiliereModule",
                column: "modulesid");

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
                name: "FiliereModule");

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

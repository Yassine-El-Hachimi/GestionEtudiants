﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionEtudiants.Migrations
{
    public partial class InitialCreate : Migration
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
                    tel = table.Column<int>(type: "int", nullable: false),
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
                    valeur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Typeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.id);
                    table.ForeignKey(
                        name: "FK_Types_Types_Typeid",
                        column: x => x.Typeid,
                        principalTable: "Types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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
                    id_professeur = table.Column<int>(type: "int", nullable: true),
                    Proffesseurid = table.Column<int>(type: "int", nullable: true),
                    id_type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.id);
                    table.ForeignKey(
                        name: "FK_Modules_Proffesseurs_Proffesseurid",
                        column: x => x.Proffesseurid,
                        principalTable: "Proffesseurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modules_Types_id_type",
                        column: x => x.id_type,
                        principalTable: "Types",
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
                    id_module = table.Column<int>(type: "int", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Absences",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "IX_Modules_id_type",
                table: "Modules",
                column: "id_type");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_Proffesseurid",
                table: "Modules",
                column: "Proffesseurid");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_id_module",
                table: "Notes",
                column: "id_module");

            migrationBuilder.CreateIndex(
                name: "IX_Types_Typeid",
                table: "Types",
                column: "Typeid");
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
                name: "Inscriptions");

            migrationBuilder.DropTable(
                name: "Proffesseurs");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Filieres");
        }
    }
}
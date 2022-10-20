using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StokTakibiWebAPI.Migrations
{
    public partial class ModelDbIlkMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YedekParca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GirisDepo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirisTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirisBelgeNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatinAlinanFirma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GirisMiktari = table.Column<int>(type: "int", nullable: false),
                    Birimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CikisDepo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CikisTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CikisMiktari = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YedekParca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CikisYapilanAracTanimi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YedekParcaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CikisYapilanAracTanimi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CikisYapilanAracTanimi_YedekParca_YedekParcaId",
                        column: x => x.YedekParcaId,
                        principalTable: "YedekParca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YedekParcaTanimi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YedekParcaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YedekParcaTanimi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YedekParcaTanimi_YedekParca_YedekParcaId",
                        column: x => x.YedekParcaId,
                        principalTable: "YedekParca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CikisYapilanAracTanimi_YedekParcaId",
                table: "CikisYapilanAracTanimi",
                column: "YedekParcaId");

            migrationBuilder.CreateIndex(
                name: "IX_YedekParcaTanimi_YedekParcaId",
                table: "YedekParcaTanimi",
                column: "YedekParcaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CikisYapilanAracTanimi");

            migrationBuilder.DropTable(
                name: "YedekParcaTanimi");

            migrationBuilder.DropTable(
                name: "YedekParca");
        }
    }
}

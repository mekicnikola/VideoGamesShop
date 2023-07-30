using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjekatNapredniWeb.Data.Migrations
{
    public partial class migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false),
                    Izdavac = table.Column<string>(maxLength: 20, nullable: false),
                    Zanr = table.Column<string>(maxLength: 20, nullable: false),
                    Platforma = table.Column<string>(maxLength: 20, nullable: false),
                    DatumIzlaska = table.Column<DateTime>(type: "date", nullable: false),
                    Slika = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proizvod");
        }
    }
}

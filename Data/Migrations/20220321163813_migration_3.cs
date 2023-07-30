using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjekatNapredniWeb.Data.Migrations
{
    public partial class migration_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Cena",
                table: "Proizvod",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cena",
                table: "Proizvod");
        }
    }
}

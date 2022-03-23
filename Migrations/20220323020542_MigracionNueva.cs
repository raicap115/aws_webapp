using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aws_webapp.Migrations
{
    public partial class MigracionNueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "participantes",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "correo",
                table: "participantes");
        }
    }
}

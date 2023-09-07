using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjekatRestoran.Migrations
{
    public partial class addJelaToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jela",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivJela = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cijena = table.Column<int>(type: "int", nullable: false),
                    OznakaJela = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jela", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jela");
        }
    }
}

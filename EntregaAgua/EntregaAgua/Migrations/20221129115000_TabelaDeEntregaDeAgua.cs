using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaAgua.Migrations
{
    public partial class TabelaDeEntregaDeAgua : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agua = table.Column<int>(type: "int", nullable: false),
                    Entregador = table.Column<int>(type: "int", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}

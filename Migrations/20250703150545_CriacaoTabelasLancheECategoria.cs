using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchoneteMVC.Migrations
{
    
    public partial class CriacaoTabelasLancheECategoria : Migration
    {
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Lanches",
                columns: table => new
                {
                    LancheId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    DescricaoCurta = table.Column<string>(type: "TEXT", nullable: false),
                    DescricaoDetalhada = table.Column<string>(type: "TEXT", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ImagemUrl = table.Column<string>(type: "TEXT", nullable: false),
                    IsLanchePreferido = table.Column<bool>(type: "INTEGER", nullable: false),
                    EmEstoque = table.Column<bool>(type: "INTEGER", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanches", x => x.LancheId);
                    table.ForeignKey(
                        name: "FK_Lanches_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lanches_CategoriaId",
                table: "Lanches",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lanches");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}

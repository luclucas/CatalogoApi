using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.InsertData(
                table: "Produto",
                columns: ["Nome", "Descricao", "Preco", "ImagemUrl", "Estoque", "DataCadastro", "CategoriaId"],
                values: ["Coca-cola", "Refri", 8.0, "coca.png", 50,DateTime.Now, 1]
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE * FROM produtos");
        }
    }
}

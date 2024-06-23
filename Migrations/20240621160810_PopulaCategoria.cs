using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.VisualBasic;

#nullable disable

namespace CatalogoApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {

            mb.InsertData(
                table: "Categoria",
                columns: ["Nome", "ImagemUrl"],
                values: ["Bebidas", "bebida.png"]   
            );
         
            mb.InsertData(
                table: "Categoria",
                columns: ["Nome", "ImagemUrl"],
                values: ["Lanches", "lanches.png"]   
            );

               mb.InsertData(
                table: "Categoria",
                columns: ["Nome", "ImagemUrl"],
                values: ["Sobremesas", "Sobremesa.png"]   
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE * FROM Categoria");

        }
    }
}

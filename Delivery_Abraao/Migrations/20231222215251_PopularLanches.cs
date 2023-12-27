using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery_Abraao.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lanches_Categorias_CategoriaId",
                table: "Lanches");

            migrationBuilder.DropColumn(
                name: "CategoriId",
                table: "Lanches");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Lanches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lanches_Categorias_CategoriaId",
                table: "Lanches",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);


            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, ImagemThumbnailUrl, ImagemUrl, EmEstoque, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, hamburguer, queijo, presunto, alface,tomate', 'Pão de brioche, hamburguer gourmet de 150g, queijo prato', 'https://i.pinimg.com/originals/16/29/c8/1629c8b6460f9613532c7ca6a4fa2f2c.jpg', 'https://croscard.com.br/rede-croscard/wp-content/uploads/2020/02/destaque-lanches.jpg', 1, 0, 'x-salada', 14.90)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, ImagemThumbnailUrl, ImagemUrl, EmEstoque, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, hamburguer, queijo, presunto', 'Pão de brioche, hamburguer gourmet de 150g, queijo prato', 'https://i.pinimg.com/originals/16/29/c8/1629c8b6460f9613532c7ca6a4fa2f2c.jpg', 'https://croscard.com.br/rede-croscard/wp-content/uploads/2020/02/destaque-lanches.jpg', 1, 0, 'x-burguer', 12.90)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, ImagemThumbnailUrl, ImagemUrl, EmEstoque, IsLanchePreferido, Nome, Preco) VALUES(2, 'Pão, queijo, alface,tomate, cenoura', 'Pão de brioche, queijo branco', 'https://i.pinimg.com/originals/16/29/c8/1629c8b6460f9613532c7ca6a4fa2f2c.jpg', 'https://croscard.com.br/rede-croscard/wp-content/uploads/2020/02/destaque-lanches.jpg', 1, 0, 'lanche natural', 9.90)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, ImagemThumbnailUrl, ImagemUrl, EmEstoque, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, hamburguer, queijo, presunto, alface,tomate, bacon', 'Pão de brioche, hamburguer gourmet de 150g, queijo prato', 'https://i.pinimg.com/originals/16/29/c8/1629c8b6460f9613532c7ca6a4fa2f2c.jpg', 'https://croscard.com.br/rede-croscard/wp-content/uploads/2020/02/destaque-lanches.jpg', 1, 1, 'x-bacon', 16.90)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, ImagemThumbnailUrl, ImagemUrl, EmEstoque, IsLanchePreferido, Nome, Preco) VALUES(1, 'Pão, hamburguer, queijo, presunto, alface,tomate, bacon, calabreza', 'Pão de brioche, hamburguer gourmet de 200g, queijo prato', 'https://i.pinimg.com/originals/16/29/c8/1629c8b6460f9613532c7ca6a4fa2f2c.jpg', 'https://croscard.com.br/rede-croscard/wp-content/uploads/2020/02/destaque-lanches.jpg', 1, 1, 'x-calabacon', 17.90)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, ImagemThumbnailUrl, ImagemUrl, EmEstoque, IsLanchePreferido, Nome, Preco) VALUES(2, 'Pão, hamburguer, queijo, peito de peru, alface,tomate', 'Pão de brioche, hamburguer de frango gourmet de 200g, queijo prato', 'https://i.pinimg.com/originals/16/29/c8/1629c8b6460f9613532c7ca6a4fa2f2c.jpg', 'https://i.pinimg.com/originals/16/29/c8/1629c8b6460f9613532c7ca6a4fa2f2c.jpg', 1, 0, 'Lanche peito de Peru', 21.90)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lanches_Categorias_CategoriaId",
                table: "Lanches");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Lanches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoriId",
                table: "Lanches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Lanches_Categorias_CategoriaId",
                table: "Lanches",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {

            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Coca-Cola', 'Refrigerante de Cola 350ml', 5.00, 'coca-cola.png', 50, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Bebidas'))");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Suco de Laranja', 'Suco Natural de Laranja 300ml', 4.50, 'suco-laranja.png', 30, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Bebidas'))");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Hambúrguer', 'Hambúrguer Artesanal com Queijo e Bacon', 15.00, 'hamburguer.png', 20, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Lanches'))");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Pizza de Calabresa', 'Pizza Média de Calabresa com Cebola', 30.00, 'pizza-calabresa.png', 10, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Lanches'))");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Pudim', 'Pudim de Leite Condensado 100g', 6.00, 'pudim.png', 25, NOW(), (SELECT CategoriaId FROM Categorias WHERE Nome = 'Sobremesas'))");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Produtos WHERE Nome IN ('Coca-Cola', 'Suco de Laranja', 'Hambúrguer', 'Pizza de Calabresa', 'Pudim')");

        }
    }
}

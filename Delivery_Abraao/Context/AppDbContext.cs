using Delivery_Abraao.Models;
using Microsoft.EntityFrameworkCore;

namespace Delivery_Abraao.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // define a classe que estou mapeando
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}

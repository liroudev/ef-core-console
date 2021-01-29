using EFCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PedidoItem> PedidosItens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=dbEFCore;Integrated Security =true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }

    }
}
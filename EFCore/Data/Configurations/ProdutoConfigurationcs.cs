using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Data.Configurations
{
    public class ProdutoConfigurationcs : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CodigoBarras).HasColumnType("VARCHAR(14)").IsRequired();
            builder.Property(p => p.Descricao).HasColumnType("VARCHAR(60");
            builder.Property(p => p.Valor).HasDefaultValue(0).IsRequired();
            builder.Property(p => p.TipoProduto).HasConversion<string>();
        }
    }
}
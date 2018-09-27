using CloseSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloseSocial.Infra.Data.Context
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nome).IsRequired();
            builder.Property(a => a.Descricao).IsRequired();
            builder.Property(a => a.UrlPhoto).IsRequired();            
        }
    }
}
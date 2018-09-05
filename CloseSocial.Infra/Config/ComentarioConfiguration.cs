using CloseSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloseSocial.Infra.Data.Context
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataPublicacao)
                .IsRequired();

            builder.Property(p => p.Texto)
                .IsRequired();            

            builder.HasOne(p => p.Usuario);

        }
    }
}
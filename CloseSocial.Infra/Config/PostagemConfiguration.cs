using CloseSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloseSocial.Infra.Data.Context
{
    public class PostagemConfiguration : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataPublicacao)
                .IsRequired();

            builder.Property(p => p.Texto)
                .IsRequired();

            builder.Property(p => p.UrlConteudo);

            builder.HasMany(p => p.Comentarios);
                
            builder.HasOne(p => p.Usuario);

        }
    }
}
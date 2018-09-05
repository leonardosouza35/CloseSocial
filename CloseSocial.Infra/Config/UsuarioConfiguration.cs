using CloseSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloseSocial.Infra.Data.Context
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome);
            builder.Property(u => u.SobreNome);
            builder.Property(u => u.Senha);
            builder.Property(u => u.Sexo);
            builder.Property(u => u.DataNascimento);
            builder.Property(u => u.CelularOrEmail);
            builder.Property(u => u.UrlFoto);
            builder.HasMany(u => u.Postagens);
            builder.HasMany(u => u.Amigos);



        }
    }
}
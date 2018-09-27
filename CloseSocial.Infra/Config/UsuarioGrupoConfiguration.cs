using CloseSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloseSocial.Infra.Data.Context
{
    public class UsuarioGrupoConfiguration : IEntityTypeConfiguration<UsuarioGrupo>
    {
        public void Configure(EntityTypeBuilder<UsuarioGrupo> builder)
        {
            builder.HasKey(a => new {a.UsuarioId, a.GrupoId });
            builder.Property(a => a.DataCriacao);
            builder.Property(a => a.EhAdministrador);
        }
    }
}
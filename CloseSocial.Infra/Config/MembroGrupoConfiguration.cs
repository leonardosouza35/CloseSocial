using CloseSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloseSocial.Infra.Data.Context
{
    public class MembroGrupoConfiguration : IEntityTypeConfiguration<MembroGrupo>
    {
        public void Configure(EntityTypeBuilder<MembroGrupo> builder)
        {
            builder.HasKey(g => g.Id);
            builder.HasOne(g => g.Usuario);
            builder.HasOne(g => g.TipoMembro).WithOne(g => g.MembrosGrupo).HasForeignKey<MembroGrupo>(g => g.TipoMembroId);
            
        }
    }
}
using CloseSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloseSocial.Infra.Data.Context
{
    public class MembrosGrupoConfiguration : IEntityTypeConfiguration<MembrosGrupo>
    {
        public void Configure(EntityTypeBuilder<MembrosGrupo> builder)
        {
            builder.HasKey(g => g.Id);
            builder.HasOne(g => g.Usuario);
            builder.HasOne(g => g.TipoMembro).WithOne(g => g.MembrosGrupo).HasForeignKey<MembrosGrupo>(g => g.TipoMembroId);
            
        }
    }
}
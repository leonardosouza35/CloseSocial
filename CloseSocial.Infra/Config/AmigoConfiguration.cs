using CloseSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloseSocial.Infra.Data.Context
{
    public class AmigoConfiguration : IEntityTypeConfiguration<Amigo>
    {
        public void Configure(EntityTypeBuilder<Amigo> builder)
        {
            builder.HasKey(a => new { a.UsuarioId, a.UsuarioAmigoId});            
        }
    }
}
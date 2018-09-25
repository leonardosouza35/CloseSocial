using CloseSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloseSocial.Infra.Data.Context
{
    public class StatusRelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        public void Configure(EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(p => p.Status);

            builder.HasData(
                new StatusRelacionamento() { Id = 1, Status = "NaoEspecificado"},
                new StatusRelacionamento() { Id = 2, Status = "Solteiro" },
                new StatusRelacionamento() { Id = 3, Status = "Casado" },
                new StatusRelacionamento() { Id = 4, Status = "EmRelacionamentoSerio" });
        }
    }
}
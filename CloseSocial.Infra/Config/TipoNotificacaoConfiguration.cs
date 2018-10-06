using CloseSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CloseSocial.Infra.Data.Context
{
    public class TipoNotificacaoConfiguration : IEntityTypeConfiguration<TipoNotificacao>
    {
        public void Configure(EntityTypeBuilder<TipoNotificacao> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Descricao);
            builder.Property(t => t.TipoNotificacaoDescricaoTest);
            builder.HasData(
                new TipoNotificacao() { Id = 1, Descricao = "AniversarioAmigo" },
                new TipoNotificacao() { Id = 2, Descricao = "SolicitacaoAmizade" });                
        }
    }
}
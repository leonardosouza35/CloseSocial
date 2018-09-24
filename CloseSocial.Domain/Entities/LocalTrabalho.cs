using Flunt.Notifications;
using System;

namespace CloseSocial.Domain.Entities
{    
    public class LocalTrabalho : Notifiable
    {
        public int Id { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataSaida { get; set; }
        public bool EmpresaAtual { get; set; }
    }
}

using Flunt.Notifications;
using System;

namespace CloseSocial.Domain.Entities
{    
    public class InstituicaoEnsino : Notifiable
    {
        public int Id { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public DateTime? AnoFormacao { get; set; }
        public bool EstudandoAtualmente { get; set; }
    }
}

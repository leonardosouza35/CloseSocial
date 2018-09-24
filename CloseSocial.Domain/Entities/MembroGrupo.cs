using Flunt.Notifications;
using System.Collections.Generic;

namespace CloseSocial.Domain.Entities
{
    public class MembroGrupo : Notifiable
    {
        public int Id { get; set; }
        public virtual int GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int TipoMembroId { get; set; }
        public virtual TipoMembro TipoMembro { get; set; }

    }
}

using Flunt.Notifications;
using System.Collections.Generic;

namespace CloseSocial.Domain.Entities
{
    public class TipoMembro : Notifiable
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual int MembrosGrupoId { get; set; }
        public virtual MembrosGrupo MembrosGrupo { get; set; }

    }
}

using Flunt.Notifications;
using System.Collections.Generic;

namespace CloseSocial.Domain.Entities
{
    public class Grupo : Notifiable
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }        
        public virtual ICollection<Postagem> Postagens { get; set; }        
        public string UrlPhoto { get; set; }
        public virtual ICollection<UsuarioGrupo> UsuarioGrupos { get; private set; }
    }
}

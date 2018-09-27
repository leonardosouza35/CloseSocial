using Flunt.Notifications;

namespace CloseSocial.Domain.Entities
{
    public class Amigo : Notifiable
    {        
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioAmigoId { get; set; }
        public virtual Usuario UsuarioAmigo { get; set; }
    }
}

using Flunt.Notifications;

namespace CloseSocial.Domain.Entities
{
    public class Amigo : Notifiable
    {
        public int Id { get; set; }

        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioAmigoId { get; set; }        
    }
}

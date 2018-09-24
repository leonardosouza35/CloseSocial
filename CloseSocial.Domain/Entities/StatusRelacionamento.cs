using Flunt.Notifications;

namespace CloseSocial.Domain.Entities
{    
    public class StatusRelacionamento : Notifiable
    {
        public int Id { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual string Status { get; set; }        
    }
}

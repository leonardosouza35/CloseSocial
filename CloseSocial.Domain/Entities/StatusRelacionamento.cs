using CloseSocial.Domain.Enums;
using Flunt.Notifications;

namespace CloseSocial.Domain.Entities
{    
    public class StatusRelacionamento : Notifiable
    {
        public int Id { get; set; }        
        public virtual string Status { get; set; }

        public bool NaoEspecificado { get { return Id == (int)StatusRelacionamentoEnum.NaoEspecificado; } }
        public bool EhSolteiro { get { return Id == (int)StatusRelacionamentoEnum.Solteiro; } }
        public bool EhCasado{ get { return Id == (int)StatusRelacionamentoEnum.Casado; } }
        public bool RelacionamentoSerio { get { return Id == (int)StatusRelacionamentoEnum.EmRelacionamentoSerio; } }
    }
}

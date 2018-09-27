using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Domain.Entities
{
    //public enum TipoNotificacaoEnum
    //{
    //    AniversarioAmigo = 1,
    //    SolicitacaoAmizade = 2
    //}
    public class Notificacao : Notifiable
    {
        public int Id { get; set; }        
        public virtual TipoNotificacao TipoNotificacao { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

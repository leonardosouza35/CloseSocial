﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Domain.Entities
{
    public class TipoNotificacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int NotificacaoId { get; set; }
        public virtual Notificacao Notificacao { get; set; }
    }
}

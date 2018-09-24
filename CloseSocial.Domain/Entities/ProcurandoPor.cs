using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Domain.Entities
{
    public class ProcurandoPor
    {
        public int Id  { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string Descricao { get; set; }
    }
}

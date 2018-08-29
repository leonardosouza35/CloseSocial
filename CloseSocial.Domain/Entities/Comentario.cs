using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Domain.Entities
{
  
    public class Comentario : Entity
    {
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }        
        public Usuario Usuario { get; set; }

        
    }
}

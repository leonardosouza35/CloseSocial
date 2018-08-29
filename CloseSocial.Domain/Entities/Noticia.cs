using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Domain.Entities
{
  
    public class Noticia : Entity
    {
        public DateTime DataPublicacao { get; set; }
        public string Conteudo { get; set; }
        public List<Comentario> Comentarios { get; set; }

        public Noticia()
        {
            Comentarios = new List<Comentario>();
        }
        public void AdicionarComentario(Comentario comentario)
        {
            if(comentario.Usuario != null)
            {
                Comentarios.Add(comentario);
            }
        }        
    }
}

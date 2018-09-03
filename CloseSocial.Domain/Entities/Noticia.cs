using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Domain.Entities
{
  
    public class Noticia : Entity
    {
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }
        public string UrlConteudo { get; set; }
        public List<Comentario> Comentarios { get; private set; }
        public Usuario Usuario { get; private set; }

        public Noticia()
        {
            DataPublicacao = DateTime.Now;
            Comentarios = new List<Comentario>();
        }

        public void SetUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }
        public void AdicionarComentario(Comentario comentario)
        {
            if(comentario.Usuario != null)            
                Comentarios.Add(comentario);
            
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

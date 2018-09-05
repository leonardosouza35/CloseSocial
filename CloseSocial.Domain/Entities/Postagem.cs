using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Domain.Entities
{
  
    public class Postagem : Notifiable
    {
        public int Id { get; private set; }
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }
        public string UrlConteudo { get; set; }
        public List<Comentario> Comentarios { get; private set; }
        public Usuario Usuario { get; private set; }

        
        public Postagem()
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
            comentario.Validate();
            if(comentario.Usuario != null)            
                Comentarios.Add(comentario);
            
        }

        public  void Validate()
        {
            AddNotifications(new Contract()
                .IsTrue(DataPublicacao != default(DateTime), "DataPublicacao", "Favor informar uma data de publicação")
                .IsNotNullOrEmpty(Texto, "Texto", "Para publicar, é necessário digitar um texto")
                .IsNotNull(Usuario, "Usuario", "Usuário não pode ser nulo")
                );
        }
    }
}

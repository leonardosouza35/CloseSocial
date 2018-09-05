using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Text;

namespace CloseSocial.Domain.Entities
{
  
    public class Comentario : Notifiable
    {
        public int Id { get; private set; }
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }        
        public Usuario Usuario { get; private set; }

        public Comentario()
        {
            DataPublicacao = DateTime.Now;
        }
        public void SetUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }
        public void Validate()
        {
            AddNotifications(
                new Contract()
                .IsTrue(DataPublicacao != default(DateTime), "DataPublicacao", "Data publicação não foi informada")
                .IsNotNullOrEmpty(Texto, "Texto", "Você deve informar um texto para seu comentário")
                .IsNotNull(Usuario, "Usuario", "Usuário não pode ser nulo")                
                );
        }
    }
}

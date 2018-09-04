using Flunt.Validations;
using System;
using System.Text;

namespace CloseSocial.Domain.Entities
{
  
    public class Comentario : Entity
    {
        public DateTime? DataPublicacao { get; set; }
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
        public override void Validate()
        {
            AddNotifications(
                new Contract()
                .IsTrue(DataPublicacao.HasValue, "DataPublicacao", "Data publicação não foi informada")
                .IsNotNullOrEmpty(Texto, "Texto", "Você deve informar um texto para seu comentário")
                .IsNotNull(Usuario, "Usuario", "Usuário não pode ser nulo")                
                );
        }
    }
}

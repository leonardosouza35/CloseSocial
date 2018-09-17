using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CloseSocial.Domain.Entities
{
    public enum SexoEnum
    {
        Feminino = 1,
        Masculino = 2
    }
    public class Usuario : Notifiable
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime? DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public string UrlFoto { get; set; }

        public virtual ICollection<Amigo> Amigos { get; private set; }
        public virtual  ICollection<Postagem> Postagens { get; private set; }
        public virtual ICollection<Grupo> Grupos { get; private set; }

        public Usuario()
        {
            Amigos = new List<Amigo>();
            Postagens = new List<Postagem>();
        }
        public void AdicionarAmigo(Amigo amigo)
        {
                                                                
            AddNotifications(
                new Contract()                
                .IsTrue(!Amigos.Any(u => u.UsuarioAmigoId == amigo.Id), "Amigos", "Amigo já foi adicionado")
                );

            if (Valid)
                Amigos.Add(amigo);
                        
        }

        
        public void Postar(Postagem post)
        {
            post.SetUsuario(this);
            post.Validate();
            AddNotifications(post.Notifications);
            
            if (Valid)                            
                Postagens.Add(post);
            
        }

        public void AdicionarComentario(Postagem post, Comentario comentario)
        {
            comentario.SetUsuario(this);
            comentario.Validate();            
            AddNotifications(comentario.Notifications);
            if (Valid)
                post.AdicionarComentario(comentario);
        }
        


        public void Validate()
        {
            AddNotifications(
                new Contract()
                .IsNotNull(Nome, "Nome", "Você deve informar um nome")
                .IsNotNull(SobreNome, "SobreNome", "Você deve informar o sobre nome")
                .IsNotNull(Senha, "Senha", "Você deve informar a senha")
                .IsNotNull(Email, "CelularOrEmail", "Você deve informar o Celular ou Email")
                .IsTrue(DataNascimento.HasValue, "DataNascimento", "Você deve informar a data de nascimento")                
                );
        }
    }
}

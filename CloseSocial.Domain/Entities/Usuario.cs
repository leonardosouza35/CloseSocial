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
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CelularOrEmail { get; set; }
        public string Senha { get; set; }
        public DateTime? DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public string UrlFoto { get; set; }

        public List<Amigo> Amigos { get; private set; }
        public List<Postagem> Postagens { get; private set; }

        public Usuario()
        {
            Amigos = new List<Amigo>();
            Postagens = new List<Postagem>();
        }
        public void AdicionarAmigo(Amigo amigo)
        {

            amigo.Validate();
                
            AddNotifications(amigo.Notifications);
            
            AddNotifications(
                new Contract()                
                .IsTrue(!Amigos.Any(u => u.CelularOrEmail == CelularOrEmail), "Amigos", "Amigo já foi adicionado")
                );

            if (Valid)
                Amigos.Add(amigo);
                        
        }

        public Usuario ObterAmigo(string emailOuSenha)
        {
            return Amigos.FirstOrDefault(a => a.CelularOrEmail == emailOuSenha);
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
        


        public override void Validate()
        {
            AddNotifications(
                new Contract()
                .IsNotNull(Nome, "Nome", "Você deve informar um nome")
                .IsNotNull(SobreNome, "SobreNome", "Você deve informar o sobre nome")
                .IsNotNull(Senha, "Senha", "Você deve informar a senha")
                .IsNotNull(CelularOrEmail, "CelularOrEmail", "Você deve informar o Celular ou Email")
                .IsTrue(DataNascimento.HasValue, "DataNascimento", "Você deve informar a data de nascimento")                
                );
        }
    }
}

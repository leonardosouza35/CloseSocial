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

        public List<Amigo> Amigos { get; private set; }
        public List<Noticia> Noticias { get; private set; }

        public Usuario()
        {
            Amigos = new List<Amigo>();
            Noticias = new List<Noticia>();
        }
        public void AdicionarAmigo(Amigo amigo)
        {
                        
            AddNotifications(
                new Contract()
                .IsTrue(amigo != null, "Nome", "Não pode informar nulo na chamada")
                .IsNotNull(amigo.Nome, "Nome", "Você deve informar um nome")
                .IsNotNull(amigo.SobreNome, "SobreNome", "Você deve informar o sobre nome")
                .IsNotNull(amigo.Senha, "Senha", "Você deve informar a senha")
                .IsNotNull(amigo.CelularOrEmail, "CelularOrEmail", "Você deve informar o Celular ou Email")
                .IsTrue(amigo.DataNascimento.HasValue, "DataNascimento", "Você deve informar a data de nascimento")
                .IsTrue(!Amigos.Any(u => u.CelularOrEmail == amigo.CelularOrEmail), "Amigos", "Amigo já foi adicionado")
                );
            

            if(Valid)
                Amigos.Add(amigo);
                        
        }

        public Usuario ObterAmigo(string emailOuSenha)
        {
            return Amigos.FirstOrDefault(a => a.CelularOrEmail == emailOuSenha);
        }

        public void AdicionarNoticia(Noticia noticia)
        {
            noticia.SetUsuario(this);
            Noticias.Add(noticia);
        }       
    }
}

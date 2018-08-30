using CloseSocial.Domain.Validations;
using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            if (amigo == null)
            {
                AddNotification("", " amigo não pode ser nulo");
                return;
            }

            var notifications = new UsuarioValidationContract(amigo).Contract.Notifications;
            AddNotifications(notifications);

            if (!notifications.Any() && !Amigos.Any(u => u.CelularOrEmail == amigo.CelularOrEmail))
            {
                Amigos.Add(amigo);
            }else
            {
                AddNotification("Amigos", "Não foi possivel adicionar um novo amigo");
            }            

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

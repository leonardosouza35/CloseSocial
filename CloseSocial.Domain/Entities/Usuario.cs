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
        public DateTime DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }

        public List<Usuario> Usuarios { get; private set; }
        public List<Noticia> Noticias { get; private set; }

        public void AdicionarAmigo(Usuario usuario)
        {
            //PreCondition
            if (!Usuarios.Any(u => u.CelularOrEmail == usuario.CelularOrEmail))
                Usuarios.Add(usuario);
            //PosCondition
        }

        public void AdicionarNoticia(Noticia noticia)
        {
            Noticias.Add(noticia);
        }
        
    }
}

using CloseSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CloseSocial.Domain.Tests.UsuarioTest
{
    public class AdicionarAmigoTest
    {
        Usuario usuario;
        Amigo amigo1;
        string emailAmigo = "teste@company.com.br";

        public AdicionarAmigoTest()
        {
            usuario = new Usuario();            
        }

        [Fact]
        public void AdicionarAmigo1SemNotificacoes()
        {
            var amigo = CriarAmigo(1);
            usuario.AdicionarAmigo(amigo);
            Assert.True(!amigo.Notifications.Any());            
        }


        [Fact]
        public void AdicionarAmigoRetornaUmAmigo()
        {
            var amigo = CriarAmigo(1);
            usuario.AdicionarAmigo(amigo);
            Assert.True(usuario.Amigos.Count() == 1);
            Assert.True(usuario.Amigos.Where(a => a.CelularOrEmail == emailAmigo).Count() == 1);

        }

        [Fact]
        public void ObterAmigoRetornaAmigo1()
        {
            var amigo = CriarAmigo(1);
            usuario.AdicionarAmigo(amigo);
            var amigoRetorno = usuario.ObterAmigo(amigo.CelularOrEmail);
            Assert.True(amigo.CelularOrEmail == amigoRetorno.CelularOrEmail);
        }

        private Amigo CriarAmigo(int usuarioId)
        {
            amigo1 = new Amigo();
            amigo1.Nome = $"nome{usuarioId}";
            amigo1.SobreNome= $"SobreNome{usuarioId}";
            amigo1.Sexo = SexoEnum.Masculino;
            amigo1.Senha = "123";
            amigo1.DataNascimento = DateTime.Now;
            amigo1.CelularOrEmail = emailAmigo;

            return amigo1;
        }
        
    }
}

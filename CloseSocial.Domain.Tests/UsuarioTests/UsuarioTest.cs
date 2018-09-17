using CloseSocial.Domain.Entities;
using System;
using System.Linq;
using Xunit;

namespace CloseSocial.Domain.Tests.UsuarioTests
{
    public class UsuarioTest: IDisposable
    {
        private Entities.Usuario usuario;
        
        public UsuarioTest()
        {
            usuario = new Usuario();
        }

        [Fact]
        public void UsuarioValidado()
        {
            
            usuario.Nome = "Usuario1";
            usuario.SobreNome = "Sobrenome";
            usuario.Senha = "123456";
            usuario.Sexo = SexoEnum.Masculino;
            usuario.DataNascimento = DateTime.Now;
            usuario.Email = "user@gmail.com";
            usuario.Validate();
            Assert.True(!usuario.Notifications.Any());
        }

       [Fact]
       public void UsuarioNaoValidado()
       {            
            usuario.Validate();
            Assert.True(usuario.Notifications.Any());
       }

        [Fact]
        public void MensagemNomeValidado()
        {
   
            usuario.Validate();        
            Assert.Contains(usuario.Notifications, n => n.Message == "Você deve informar um nome");
            
        }


        [Fact]
        public void MensagemSobreNomeValidado()
        {            
            usuario.Validate();
            
            Assert.Contains(usuario.Notifications, n => n.Message == "Você deve informar o sobre nome");
        }

        public void Dispose()
        {
            usuario = null;
        }
    }
}

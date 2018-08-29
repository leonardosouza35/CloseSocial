using CloseSocial.Domain.Entities;
using CloseSocial.Domain.Validations;
using System;
using System.Linq;
using Xunit;

namespace CloseSocial.Domain.Tests
{
    public class UsuarioTest
    {
        Usuario usuario;
        Usuario amigo1;
        Usuario amigo2;

        
        [Fact]
        public void CriacaoUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.Id = 1;
            usuario.Nome = "Usuario1";
            usuario.SobreNome = "Sobrenome";
            usuario.Senha = "123456";
            usuario.Sexo = SexoEnum.Masculino;
            usuario.DataNascimento = DateTime.Now;

            var notifications = new UsuarioValidationContract(usuario).Contract.Notifications;
            Assert.True(notifications.Any());
        }
    }
}

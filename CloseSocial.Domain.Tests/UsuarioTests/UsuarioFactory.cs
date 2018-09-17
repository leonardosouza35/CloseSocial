using CloseSocial.Domain.Entities;
using System;

namespace CloseSocial.Domain.Tests.UsuarioTests
{
    public class UsuarioFactory
    {
        public Usuario CriarUsuario(int usuarioId, string emailOuSenha)
        {
            Usuario usuario = new Usuario();            
            usuario.Nome = $"nome{usuarioId}";
            usuario.SobreNome = $"SobreNome{usuarioId}";
            usuario.Sexo = SexoEnum.Masculino;
            usuario.Senha = "123";
            usuario.DataNascimento = DateTime.Now;
            usuario.Email = emailOuSenha;

            return usuario;
        }
    }
}

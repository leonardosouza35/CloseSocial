using CloseSocial.Domain.Entities;
using CloseSocial.Domain.Tests.UsuarioTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CloseSocial.Domain.Tests.UsuarioTest
{
    public class AdicionarPostagemTest
    {
        Usuario usuario1;
        Postagem post1;
        Postagem post2;
        UsuarioFactory usuarioFactory;
        
        public AdicionarPostagemTest()
        {
            usuario1 = new Usuario();
            usuarioFactory = new UsuarioFactory();
        }
        

        [Fact]
        public void AdicionarPostSemNotificacoes()
        {
            usuario1 = usuarioFactory.CriarUsuario(1, "usuario1@teste.com");
            post1 = new Postagem() {Texto = "Hoje é dia de jogo" };
            usuario1.Postar(post1);
            Assert.True(!usuario1.Notifications.Any());
        }
       
        [Fact]
        public void Adicionar2PostsRetornaPost1()
        {
            post1 = new Postagem() { Texto = "Texto Noticia 1" };
            post2 = new Postagem() { Texto = "Texto Noticia 2" };
            usuario1.Postar(post1);
            usuario1.Postar(post2);
            Assert.True(usuario1.Postagens.Count(n => n.Texto == "Texto Noticia 1") == 1);
        }
    }
}

using CloseSocial.Domain.Entities;
using System;
using System.Linq;
using Xunit;

namespace CloseSocial.Domain.Tests
{
    public class UsuarioTest
    {
        Usuario usuario;
        Amigo amigo1;
        Usuario amigo2;
        Noticia noticia1;

        
        [Fact]
        public void CriacaoUsuarioValidado()
        {
            Usuario usuario = new Usuario();            
            usuario.Nome = "Usuario1";
            usuario.SobreNome = "Sobrenome";
            usuario.Senha = "123456";
            usuario.Sexo = SexoEnum.Masculino;
            usuario.DataNascimento = DateTime.Now;
            usuario.CelularOrEmail = "user@gmail.com";
            
            Assert.True(!usuario.Notifications.Any());
        }

        [Fact]
        public void AdicionarUmAmigoRetornaAmigo1()
        {
            usuario = new Usuario();
            amigo1 = new Amigo();

            usuario.AdicionarAmigo(null);
            var notificaions = usuario.Notifications;
            var amigoRetorno = usuario.ObterAmigo(amigo1.CelularOrEmail);
            
            Assert.NotNull(amigoRetorno);            
        }


        [Fact]
        public void AdicionarUmaNoticiaRetornaNoticia1()
        {
            usuario = new Usuario();            
            noticia1 = new Noticia();
            noticia1.Id = 1;
            noticia1.Texto = "conteudo1";
            noticia1.UrlConteudo = "";
            noticia1.AdicionarComentario(new Comentario());                      
            usuario.AdicionarNoticia(noticia1);

            var noticiaRetorno = usuario.Noticias.FirstOrDefault(n => n.Id == noticia1.Id);
            Assert.NotNull(noticiaRetorno);
        }
    }
}

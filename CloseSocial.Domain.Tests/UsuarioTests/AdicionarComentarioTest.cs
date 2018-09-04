using CloseSocial.Domain.Entities;
using CloseSocial.Domain.Tests.UsuarioTests;
using System.Linq;
using Xunit;

namespace CloseSocial.Domain.Tests.UsuarioTest
{
    public class AdicionarComentarioTest
    {
        Usuario usuario1;
        Usuario usuario2;
        Postagem post1;
        UsuarioFactory usuarioFactory;
        
        public AdicionarComentarioTest()
        {            
            usuarioFactory = new UsuarioFactory();
            CriarPostEComentarios();
        }



        [Fact]
        public void Usuario1CriouSomenteUmPost()
        {
            Assert.True(usuario1.Postagens.Count() ==1);
        }

        [Fact]
        public void Usuario1CriouPost1()
        {
            Assert.True(post1.Usuario.CelularOrEmail == usuario1.CelularOrEmail);
        }


        [Fact]
        public void ExistemSomenteDoisComentarios()
        {
            Assert.True(post1.Usuario.Postagens.First().Comentarios.Count() == 2 );
        }


        [Fact]
        public void Usuario2FezUmComentario()
        {
            Assert.Contains(post1.Usuario.Postagens, p => p.Comentarios.Any(c => c.Usuario.CelularOrEmail == usuario2.CelularOrEmail));
        }

        [Fact]
        public void Usuario2FezOPrimeiroComentario()
        {
            Assert.True(post1.Usuario.Postagens.First().Comentarios.OrderBy(c => c.DataPublicacao).First(cm => cm.Usuario.CelularOrEmail == usuario2.CelularOrEmail) != null);
        }

        [Fact]
        public void Usuario1FezUmComentario()
        {
            Assert.Contains(post1.Usuario.Postagens, p => p.Comentarios.Any(c => c.Usuario.CelularOrEmail == usuario1.CelularOrEmail));
        }
        

        internal void CriarPostEComentarios()
        {
            usuario1 = usuarioFactory.CriarUsuario(1, "usuario1@teste.com");
            usuario2 = usuarioFactory.CriarUsuario(2, "usuario2@teste.com");

            post1 = new Postagem() { Texto = "Hoje é dia de jogo" };
            usuario1.Postar(post1);

            usuario2.AdicionarComentario(post1, new Comentario() { Texto = "Meu comentario" });
            usuario1.AdicionarComentario(post1, new Comentario() { Texto = "Ok, bacana!" });
        }
    }
}

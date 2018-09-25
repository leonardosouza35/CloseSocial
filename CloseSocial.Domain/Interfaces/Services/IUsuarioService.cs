using CloseSocial.Domain.Entities;

namespace CloseSocial.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        Usuario ObterUsuarioPorNome(string nome);
        Usuario ObterUsuarioPorEmail(string email);
    }
}

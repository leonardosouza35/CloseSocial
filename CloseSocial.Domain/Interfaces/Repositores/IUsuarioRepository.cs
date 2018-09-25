using CloseSocial.Domain.Entities;
using System.Collections.Generic;

namespace CloseSocial.Domain.Interfaces.Repositores
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Usuario ObterUsuarioPorNome(string nome);
        Usuario ObterUsuarioPorEmail(string email);
    }
}

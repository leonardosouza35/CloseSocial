using CloseSocial.Domain.Entities;
using CloseSocial.Domain.Interfaces.Repositores;
using CloseSocial.Domain.Interfaces.Services;

namespace CloseSocial.Application.AppServices
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioRepository
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioAppService(IUsuarioService service) : base(service)
        {
            _usuarioService = service;
        }

        public Usuario ObterUsuarioPorEmail(string email)
        {
            return _usuarioService.ObterUsuarioPorEmail(email);
        }

        public Usuario ObterUsuarioPorNome(string nome)
        {
            return _usuarioService.ObterUsuarioPorNome(nome);
        }
    }
}

using CloseSocial.Domain.Entities;
using CloseSocial.Domain.Interfaces.Repositores;
using CloseSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario ObterUsuarioPorEmail(string email)
        {
            return _usuarioRepository.ObterUsuarioPorEmail(email);
        }

        public Usuario ObterUsuarioPorNome(string nome)
        {
            return _usuarioRepository.ObterUsuarioPorNome(nome);
        }
    }
}

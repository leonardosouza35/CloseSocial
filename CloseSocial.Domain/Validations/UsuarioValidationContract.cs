using CloseSocial.Domain.Entities;
using FluentValidator.Validation;

namespace CloseSocial.Domain.Validations
{
    public class UsuarioValidationContract : IContract
    {
        public ValidationContract Contract { get; }

        public UsuarioValidationContract(Usuario usuario)
        {
            Contract = new ValidationContract();
            Contract
                .Requires()
                .IsNotNull(usuario.Nome, "Nome", "Você deve informar um nome");
        }
    }
}

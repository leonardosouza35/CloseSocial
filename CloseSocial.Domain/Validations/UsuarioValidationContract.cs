using CloseSocial.Domain.Entities;
using FluentValidator;
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
                .IsNotNull(usuario.Nome, "Nome", "Você deve informar um nome")
                .IsNotNull(usuario.SobreNome, "SobreNome", "Você deve informar o sobre nome")
                .IsNotNull(usuario.Senha, "Senha", "Você deve informar a senha")
                .IsNotNull(usuario.CelularOrEmail, "CelularOrEmail", "Você deve informar o Celular ou Email")
                .IsTrue(usuario.DataNascimento.HasValue, "DataNascimento", "Você deve informar a data de nascimento");

        }
    }
}

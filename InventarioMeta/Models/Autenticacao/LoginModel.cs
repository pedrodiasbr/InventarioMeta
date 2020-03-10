using System.ComponentModel.DataAnnotations;

namespace InventarioMeta.Models.Autenticacao
{
    public class LoginModel
    {
        [System.Web.Mvc.HiddenInput]
        public string UrlRetorno { get; set; }

        [System.Web.Mvc.HiddenInput]
        public string Token { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirme a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        [Compare(nameof(Senha), ErrorMessage = "A senha e a confirmação não estão iguais")]
        [MaxLength(20)]
        public string ConfirmacaoSenha { get; set; }

        [Required(ErrorMessage = "Informe o E-mail")]
        [Display(Name = "E-mail")]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o CNPJ")]
        [Display(Name = "CNPJ")]
        [MaxLength(18)]
        public string Cnpj { get; set; }
    }
}
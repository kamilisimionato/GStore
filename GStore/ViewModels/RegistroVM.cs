using System.ComponentModel.DataAnnotations;

namespace GStore.ViewModels;

public class RegistroVM
{
    [Display(Name = "Nome Completa", Prompt = "Informe seu Nome Completo")]
    [Required(ErrorMessage = "Por favor, informe seu Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento", Prompt = "Informe sua Data de Nascimento")]
    [Required(ErrorMessage = "POr favor, informe sua Data de Nascimento")]
    public DateTime? DataNascimento { get; set; } = null;

    [Display(Prompt = "Informe seu Email")]
    [Required(ErrorMessage = "Por favor, informe seu Email")]
    [EmailAddress(ErrorMessage = "POr favor, informe um Email válido!")]
    [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracteres")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso", Prompt = "Informe uma senha para Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha de Acesso")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "A sua Senha deve possuir no mínimo 6 e no máximo 20 caracteres")]
    public string Senha { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirmar Senha de Acesso", Prompt = "Informe sua Senha de Acesso")]
    [Compare("Senha", ErrorMessage = "As Senhas não conferem.")]
    public string ConfirmacaoSenha { get; set; }

    public IFormFile Foto { get; set; }
}
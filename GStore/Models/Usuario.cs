namespace GStore.Models;

public class Usuario : IdentityUser
{
    [Required(ErrorMessage = "Informe seu nome")]
    [StringLenght(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Data de Nascimento")]
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [StringLenght(200)]
    public string Foto { get; set; }
}

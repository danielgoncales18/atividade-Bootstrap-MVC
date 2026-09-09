using System.ComponentModel.DataAnnotations;

namespace CerimonialCasamentos.Models;

public class Cerimonia
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome da noiva.")]
    public string Noiva { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe o nome do noivo.")]
    public string Noivo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe a data da cerimônia.")]
    [DataType(DataType.Date)]
    public DateTime Data { get; set; }

    [Required(ErrorMessage = "Informe o local.")]
    public string Local { get; set; } = string.Empty;

    [Range(1, 1000, ErrorMessage = "Informe uma quantidade válida.")]
    [Display(Name = "Convidados previstos")]
    public int QuantidadeConvidados { get; set; }
}
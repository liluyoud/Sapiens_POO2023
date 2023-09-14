using Sapiens.Shared.Enums;
using Sapiens.Shared.Extensions;
using Sapiens.Shared.Helpers;

namespace Sapiens.Shared.Dtos;

public class AlunoDto
{
    public string? Nome { get; set; }
    public string? PrimeiroNome { get; set; }
    public string? UltimoNome { get; set; }
    public DateTime? DataNascimento { get; set; }
    public int? Idade { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Celular { get; set; }
    public SexoEnum Sexo { get; set; }

}

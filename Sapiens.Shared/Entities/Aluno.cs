using Sapiens.Shared.Enums;
using Sapiens.Shared.Extensions;
using Sapiens.Shared.Helpers;

namespace Sapiens.Shared.Entities;

public class Aluno
{
    public string? Nome { get; set; }
    public string? PrimeiroNome => Nome.GetPrimeiroNome();
    public string? UltimoNome => Nome.GetUltimoNome();
    public DateTime? DataNascimento { get; set; }
    public int? Idade => DataNascimento.GetIdade();
    public string? Cpf { get; set; }
    public bool CpfValido => Cpf.IsCpf();

    private string? email;
    public string? Email {
        get { return email; } 
        set { email = StringHelper.VerificaEmail(value) ? value : null; }
    }

    private string? celular;
    public string? Celular {
        get { return celular; }
        set { email = StringHelper.VerificaTelefone(value) ? value : null; }
    }
    public SexoEnum Sexo { get; set; }

}

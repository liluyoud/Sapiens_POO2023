namespace Sapiens.Shared.Extensions;

public static class DocumentoExtension
{
    public static bool IsCpf(this string? cpf)
    {
        if (cpf == null) return false;
        cpf = cpf.GetNumeros();

        int soma = 0;
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (10 - i);
        }

        int primeiroDigitoVerificador = (soma % 11) < 2 ? 0 : 11 - (soma % 11);

        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (11 - i);
        }

        int segundoDigitoVerificador = (soma % 11) < 2 ? 0 : 11 - (soma % 11);

        return cpf[9] == char.Parse(primeiroDigitoVerificador.ToString()) && cpf[10] == char.Parse(segundoDigitoVerificador.ToString());
    }
}

namespace Sapiens.Shared.Extensions;

public static class StringExtension
{
    public static string? GetPrimeiroNome(this string? nome)
    {
        if (nome == null) return null;
        var nomes = nome.Split(' ');
        return nomes[0];
    }

    public static string? GetUltimoNome(this string? nome)
    {
        if (nome == null) return null;
        var nomes = nome.Split(' ');
        return nomes[nomes.Length - 1];
    }

    public static string GetNumeros(this string texto)
    {
        return new string(texto.Where(char.IsDigit).ToArray());
    }
}

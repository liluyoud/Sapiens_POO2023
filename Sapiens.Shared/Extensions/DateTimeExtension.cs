namespace Sapiens.Shared.Extensions;

public static class DateTimeExtension
{
    public static int? GetIdade(this DateTime? dataNascimento)
    {
        if (dataNascimento == null) return null;
        int idade = DateTime.Now.Year - dataNascimento.Value.Year;
        if (DateTime.Now.DayOfYear < dataNascimento.Value.DayOfYear)
            idade--;
        return idade;
    }
}

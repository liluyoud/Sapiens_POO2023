using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Sapiens.Shared.Helpers;

public static class StringHelper
{
    public static bool VerificaEmail(string? email)
    {
        if (email == null) return false;
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(email);
        if (!match.Success) return false;
        return true;
    }

    public static bool VerificaTelefone(string? telefone)
    {
        if (telefone == null) return false;
        Regex regex = new Regex(@"^[(]{1}\d{2}[)] {1}\d{5}[-]{1}\d{4}$");
        Match match = regex.Match(telefone);
        if (!match.Success) return false;
        return true;
    }
}

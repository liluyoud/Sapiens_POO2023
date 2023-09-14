using Sapiens.Shared.Dtos;
using Sapiens.Shared.Extensions;
using System.Net.Http.Json;

namespace Sapiens.Shared.Helpers;

public static class ApiHelper
{
    private static HttpClient http = new();

    public static async Task<CepDto?> GetCep(string cep)
    {
        cep = cep.GetNumeros();
        var cepDto = await http.GetFromJsonAsync<CepDto>($"https://viacep.com.br/ws/{cep}/json");
        return cepDto;
    }
}

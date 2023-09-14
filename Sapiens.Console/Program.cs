using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;
using Sapiens.Shared.Helpers;

Console.WriteLine("Sistema Sapiens");
Console.WriteLine("--------------------------------");

var aluno = new Aluno();
aluno.Nome = "Liluyoud Cury de Lacerda";
aluno.DataNascimento = DateTime.Parse("25/07/1973");
aluno.Cpf = "175.504.618-99";
aluno.Email = "lilo@mail.com";
aluno.Celular = "(69) 98114-1732";
aluno.Sexo = SexoEnum.Masculino;
aluno.Cep = "76820-888";
await aluno.BuscaCep();

Console.WriteLine($"Nome:         {aluno.Nome}");
Console.WriteLine($"Primero Nome: {aluno.PrimeiroNome}");
Console.WriteLine($"Sobrenome:    {aluno.UltimoNome}");
Console.WriteLine($"Nascimento:   {aluno.DataNascimento?.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Idade:        {aluno.Idade}");
Console.WriteLine($"Email:        {aluno.Email}");
Console.WriteLine($"Celular:      {aluno.Celular}");
if (aluno.CpfValido)
    Console.WriteLine($"Cpf Válido:   {aluno.Cpf}");
else
    Console.WriteLine($"Cpf Inválido: {aluno.Cpf}");
Console.WriteLine($"Cep:          {aluno.Cep}");
Console.WriteLine($"Logradouro:   {aluno.Logradouro}");
Console.WriteLine($"Bairro:       {aluno.Bairro}");
Console.WriteLine($"Cidade:       {aluno.Localidade}");
Console.WriteLine($"UF:           {aluno.Uf}");



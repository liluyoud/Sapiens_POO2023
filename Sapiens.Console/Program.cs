using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;

Console.WriteLine("Sistema Sapiens");
Console.WriteLine("ALUNO --------------------------------");

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


Console.WriteLine("PROFESSOR --------------------------------");

var professor = new Professor();
professor.Nome = "Liluyoud Cury de Lacerda";
professor.DataNascimento = DateTime.Parse("25/07/1973");
professor.Cpf = "175.504.618-99";
professor.Email = "lilo@mail.com";
professor.Celular = "(69) 98114-1732";
professor.Sexo = SexoEnum.Masculino;
professor.Cep = "76820-888";
await professor.BuscaCep();

Console.WriteLine($"Nome:         {professor.Nome}");
Console.WriteLine($"Primero Nome: {professor.PrimeiroNome}");
Console.WriteLine($"Sobrenome:    {professor.UltimoNome}");
Console.WriteLine($"Nascimento:   {professor.DataNascimento?.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Idade:        {professor.Idade}");
Console.WriteLine($"Email:        {professor.Email}");
Console.WriteLine($"Celular:      {professor.Celular}");
if (professor.CpfValido)
    Console.WriteLine($"Cpf Válido:   {professor.Cpf}");
else
    Console.WriteLine($"Cpf Inválido: {professor.Cpf}");
Console.WriteLine($"Cep:          {professor.Cep}");
Console.WriteLine($"Logradouro:   {professor.Logradouro}");
Console.WriteLine($"Bairro:       {professor.Bairro}");
Console.WriteLine($"Cidade:       {professor.Localidade}");
Console.WriteLine($"UF:           {professor.Uf}");
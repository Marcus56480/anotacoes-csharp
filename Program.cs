/*
Console.WriteLine("Hello, World!");

Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.Write("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

// Concatenação de valores
Console.WriteLine("Meu nome é " + nome + " e o sobre nome é "  + sobrenome);

// Interpolação de valores
Console.WriteLine($"Meu nome é {nome} e o sobrenome é {sobrenome}");
*/

// Formatação de valores
// using System.Net.NetworkInformation;

// decimal preco = 1250.5m;

// Console.WriteLine($"Preço: {preco:F2}");
// Console.WriteLine($"Preço: {preco:C}");

// preco = 1000.00m;

// // const double pi = 3.1415;
// // pi = 3.14;
 
// // Conversão de tipos 
// double valor = 9.8;
// int numero = (int)valor;

// Console.WriteLine(numero);

// string texto = "25";
// int idade = int.Parse(texto);

// Console.WriteLine(idade);

//TryParse: Tenta converter um valor sem lançar uma "excpetion"(erro) quando a conversão em falha

string texto = "25f";

if (int.TryParse(texto, out int idade))
{
    Console.WriteLine($"Idade: {idade}");
}

else
{
    Console.WriteLine("Valor inválido");
}
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

// string texto = "25f";

// if (int.TryParse(texto, out int idade))
// {
//     Console.WriteLine($"Idade: {idade}");
// }

// else
// {
//     Console.WriteLine($"Valor inválido {texto}");
// }

// // Estruturas de decisão 
// int numero = 20;
// if (idade >= 18)
// {
//     Console.WriteLine("Maior de idade");
// }

// else
// {
//     Console.WriteLine("Menor de idade");
// }

//Switch case 
// Console.WriteLine("""
// Selecione a opção desejada:
// 1 - Cadastrar 
// 2 - Consultar 
// 3 - Excluir 
// """);

// Console.WriteLine("Digite uma opção: ");
// int opcao = int.Parse(Console.ReadLine()!);

// switch (opcao)
// {
//     case 1: 
//         Console.WriteLine("Opção Cadastrar foi selecionada");
//         break;

//     case 2:
//         Console.WriteLine("Opção Consultar foi selecionada");
//         break;

//     case 3:
//         Console.WriteLine("Opção Excluir foi selecionada");
//         break;

//     default:
//         Console.WriteLine("Nenhuma opção válida selecionda");
//         break;
// }

// Estruturas de repetição 
// for
// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }

// // While
// int j = 1;
// while (j <= 5)
// {
//     Console.WriteLine(j);
//     j++;
// }

// // do while 
// string senha;
// do
// {
//     Console.Write("Digite sua senha: ");
//     senha = Console.ReadLine()!;
// } while (senha != "123");

// Console.WriteLine("Acesso liberado");

// Metódos: Funções contidas dentro de classes
// using System.Formats.Asn1;

// void ExibirMensagem()
// {
//     Console.WriteLine("Hello World");
// }

// ExibirMensagem();

// void exibirNome(string nome)
// {
//     Console.WriteLine($"Olá, {nome}");
// }

// exibirNome("Neymar");

// int somar(int a, int b)
// {
//     if (a > 0)
//     {
//         return a + b;
//     }

//     else
//     {
//         return 0;
//     }
// }

// Console.WriteLine(somar(123, 3435));

// Arrays e coleções 
// Arrays: Armazena varios dados de um mesmo tipo(string, int, bool e etc)
int[] numeros = {10, 20, 30, 40, 50}; // Instanciando o array (Passando seu valor inicial) já definindo seus valores e posições;

string[] nomes = new string[3]; // Criando um array que já possui três posições, sem valores definidos;

nomes[0] = "Neymar";
nomes[1] = "Gabigol";
nomes[2] = "Coutinho";

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);
Console.WriteLine(nomes.Length);
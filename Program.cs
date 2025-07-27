using estudos_dot_net.Models;

Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("VOGAL");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "Paula Tejano";
// pessoa.Idade = 35;
// pessoa.Apresentar();

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// Olá, meu nome é Paula Tejano e tenho 35 anos.
// 01/08/2025 18:12
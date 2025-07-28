using estudos_dot_net.Models;

// colacar no arquivo Program.cs
// refatoração 

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar sessão");

    opcao = Console.ReadLine();

    switch(opcao)
    {
    case "1":
        Console.WriteLine("Cadastro de Cliente");
        break; 
    case "2":
        Console.WriteLine("Buscar um Específico");
        break; 
    case "3":
        Console.WriteLine("Apagar um Cliente");
        break; 
    case "4":
        Console.WriteLine("Encerrando a sessão...");
        exibirMenu = false;
        break; 
    default:
        Console.WriteLine("Opção inválida!");
        break;
    }

}
Console.WriteLine("O programa encerrou.");
using estudos_dot_net.Models;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 5;
arrayInteiros[1] = 10;
arrayInteiros[2] = 15;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// percorrendo o array com FOR
for (int cont = 0; cont < arrayInteiros.Length; cont++)
{
    Console.WriteLine($"Posição nº {cont} - {arrayInteiros[cont]}");
}

// percorrendo o array com FOREACH
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

// colacar no arquivo Program.cs
// refatoração 

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar sessão");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//     case "1":
//         Console.WriteLine("Cadastro de Cliente");
//         break; 
//     case "2":
//         Console.WriteLine("Buscar um Específico");
//         break; 
//     case "3":
//         Console.WriteLine("Apagar um Cliente");
//         break; 
//     case "4":
//         Console.WriteLine("Encerrando a sessão...");
//         exibirMenu = false;
//         break; 
//     default:
//         Console.WriteLine("Opção inválida!");
//         break;
//     }

// }
// Console.WriteLine("O programa encerrou.");
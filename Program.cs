using System;
using System.Windows.Markup;

string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";

void ExibirMensagemInicial()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);

    
}
ExibirMensagemInicial();
ExibirMenuComOpcoes();

void ExibirMenuComOpcoes()
{
    Console.WriteLine("Digite 1 para registrar  uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite 0 para sair.");

    Console.Write("\nDigite sua Opção: ");
    var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
    
    switch (opcaoEscolhida)
    {
        case 1:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            break;
        case 2: Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            break;
        case 3:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            break;
        case 4:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            break;
        case 0:
            Console.WriteLine("Fui :/");
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    
    }
    

}



using System;
using System.Collections.Generic;
using System.Windows.Markup;

string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";


Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());
void ExibirLogo()
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

ExibirMenuComOpcoes();

void ExibirMenuComOpcoes()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar  uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite 0 para sair.");

    Console.Write("\nDigite sua Opção: ");
    var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
    
    switch (opcaoEscolhida)
    {
        case 1: RegistrarBandas();
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            break;
        case 2: ExibirBandas(); 
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            break;
        case 3: AvaliarUmaBanda();
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

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da Banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep( 2000 );
    Console.Clear();
    ExibirMenuComOpcoes();
}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as Bandas Registradas");
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    } 
    Console.WriteLine("\nPressione uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota entre 0 e 10 a banda {nomeDaBanda} merece: ");
        var nota = Convert.ToInt32(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        for (int i = 0; i <= 2; i++)
        {
            Console.Write(".");
            Thread.Sleep(1500);
        }
        Console.Clear();
        ExibirMenuComOpcoes();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada\n");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuComOpcoes();
    }

}

ExibirMenuComOpcoes();




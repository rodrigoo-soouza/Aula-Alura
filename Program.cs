using System;
using System.Windows.Markup;

string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Annita" };

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

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("********************************\n");
    Console.Write("Digite o nome da Banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep( 2000 );
    Console.Clear();
    ExibirMenuComOpcoes();
}

void ExibirBandas()
{
    Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("Exibindo todas as Bandas Registradas");
    Console.WriteLine("*****************************************\n");
  /*  for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    } */
    foreach(string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
}

ExibirMenuComOpcoes();




using Zuplae.Aulas.Atv0012.ConsoleApp;
using Zuplae.Aulas.Atv0012.Services;

Console.WriteLine("-------------------------------SISTEMA DE CADASTRO DA ATIVIDADE 0012-------------------------------");

Console.WriteLine("ESCOLHA UMA DAS OPÇÕES DO MENU ABAIXO: "); 
Console.WriteLine("\t1 - Endereço");
Console.WriteLine("\t2 - Fornecedor");
Console.WriteLine("\t3 - Produto");
Console.WriteLine("\t4 - Sair");

Console.WriteLine("Digite a opção: ");
int opcao = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine($"Opção escolhida: {opcao}");

switch (opcao)
{
    case 1:
        TelaEndereco telaEndereco = new TelaEndereco();
        telaEndereco.ExecutarMenu();

        break;
    case 2:
        TelaFornecedor telaFornecedor = new TelaFornecedor();
        telaFornecedor.ExecutarMenu();
        break;
    case 3:
        TelaProduto telaProduto = new TelaProduto();
        telaProduto.ExecutarMenu();
        break;
    case 4:
        Console.WriteLine("Você escolheu Sair.");
        break;
    default:
        Console.WriteLine("Opção Inválida!");
        break;
}
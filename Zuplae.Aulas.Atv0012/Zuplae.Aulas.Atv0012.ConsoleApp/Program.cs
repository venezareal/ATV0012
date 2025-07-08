using Zuplae.Aulas.Atv0012.Models;

Console.WriteLine("\t------------------ATIVIDADE 12------------------\n\n");


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("╔══════════════════════════════════════════════╗");
Console.WriteLine("║           INFORMAÇÕES DO ENDEREÇO          ║");
Console.WriteLine("╚══════════════════════════════════════════════╝");
Console.ResetColor();

Endereco endereco1 = new Endereco();
Endereco endereco2 = new Endereco();

endereco1.SetRua("Gioconda Martins");
endereco1.SetNumero("55");
endereco1.SetBairro("BaixadinhaVerde");
endereco1.SetCidade("Diamantina");
endereco1.SetEstado("Minas Gerais");
endereco1.SetCep("40.764-002");


endereco2.SetRua("Rua 72");
endereco2.SetNumero("89");
endereco2.SetBairro("Centro");
endereco2.SetCidade("Copázio");
endereco2.SetEstado("Mato Grosso");
endereco2.SetCep("10.687-001");


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("╔══════════════════════════════════════════════╗");
Console.WriteLine("║           INFORMAÇÕES DO FORNECEDOR          ║");
Console.WriteLine("╚══════════════════════════════════════════════╝");
Console.ResetColor();

Fornecedor fornecedor1 = new Fornecedor();
Fornecedor fornecedor2 = new Fornecedor();

fornecedor1.SetRazaoSocial("Motorola");
fornecedor1.SetCnpj("12.563.655/0001-56");
fornecedor1.SetEndereco(endereco1);

fornecedor2.SetRazaoSocial("Santa");
fornecedor2.SetCnpj("02.135.687/0001-98");
fornecedor2.SetEndereco(endereco2);


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("╔══════════════════════════════════════════════╗");
Console.WriteLine("║           INFORMAÇÕES DO PRODUTO             ║");
Console.WriteLine("╚══════════════════════════════════════════════╝");
Console.ResetColor();


Produto produto1 = new Produto();
Produto produto2 = new Produto();

produto1.SetCodigoProduto("230");
produto1.SetPrecoProduto(3.000m);
produto1.SetFornecedor(fornecedor1);

produto2.SetNomeProduto("Maca");
produto2.SetCodigoProduto("580");
produto2.SetPrecoProduto(600.50m);
produto2.SetFornecedor(fornecedor2);


Console.WriteLine("\n\n\tINFORMAÇÕES PRODUTO 1: \n");
Console.WriteLine(produto1);
Console.WriteLine(produto1);
Console.WriteLine("\n\n\tINFORMAÇÕES PRODUTO 2: \n");
Console.WriteLine(produto2);
Console.WriteLine(produto2);

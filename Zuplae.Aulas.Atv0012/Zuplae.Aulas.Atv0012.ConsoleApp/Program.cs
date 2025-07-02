using Zuplae.Aulas.Atv0012.Models;

Console.WriteLine("\t------------------ATIVIDADE 12------------------\n\n");

Endereco endereco1 = new Endereco();
Endereco endereco2 = new Endereco();

endereco1.rua = "Gioconda Martins";
endereco1.numero = "55";
endereco1.bairro = "BaixadinhaVerde";
endereco1.cidade = "Diamantina";
endereco1.estado = "Minas Gerais";
endereco1.cep = "40.764-002";


endereco2.rua = "72";
endereco2.numero = "66";
endereco2.bairro = "Centro";
endereco2.cidade = "Copázio";
endereco2.estado = "Mato Grosso";
endereco2.cep = "10.687-001";


Fornecedor fornecedor1 = new Fornecedor();
Fornecedor fornecedor2 = new Fornecedor();

fornecedor1.razaoSocial = "Motorola";
fornecedor1.cnpj = "12.563.655/0001-56";
fornecedor1.endereco = endereco1;

fornecedor2.razaoSocial = "Santa";
fornecedor2.cnpj = "02.135.687/0001-98";
fornecedor2.endereco = endereco2;


Produto produto1 = new Produto();
Produto produto2 = new Produto();

produto1.nomeProduto = "celular";
produto1.codigoProduto = "230";
produto1.precoProduto = "3.000";
produto1.fornecedor = fornecedor1;

produto2.nomeProduto = "Maca";
produto2.codigoProduto = "580";
produto2.precoProduto = "600,50";
produto2.fornecedor = fornecedor2;


Console.WriteLine(produto1);
Console.WriteLine(produto2);
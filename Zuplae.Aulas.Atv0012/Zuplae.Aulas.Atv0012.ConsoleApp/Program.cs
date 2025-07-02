using Zuplae.Aulas.Atv0012.Models;

Console.WriteLine("\t------------------ATIVIDADE 12------------------\n\n");

Endereco endereco = new Endereco();

Fornecedor fornecedor = new Fornecedor();

Produto celular = new Produto();

celular.nomeProduto = "celular";
celular.codigoProduto = "230";
celular.precoProduto = "3.000";
celular.fornecedor.razaoSocial = "Motorola";
celular.fornecedor.cnpj = "12.563.655/0001-56";
celular.fornecedor.endereco.rua = "Gioconda Martins";
celular.fornecedor.endereco.numero = "55";
celular.fornecedor.endereco.bairro = "BaixadinhaVerde";
celular.fornecedor.endereco.cidade = "Diamantina";
celular.fornecedor.endereco.estado = "Minas Gerais";
celular.fornecedor.endereco.cep = "40.764-002";

Console.WriteLine(celular);


Produto cadeira = new Produto();

cadeira.nomeProduto = "cadeira";
cadeira.codigoProduto = "524";
cadeira.precoProduto = "631";
cadeira.fornecedor.razaoSocial = "Vianna";
cadeira.fornecedor.cnpj = "12.563.655/0001-56";
cadeira.fornecedor.endereco.rua = "Soraia Beltran";
cadeira.fornecedor.endereco.numero = "46";
cadeira.fornecedor.endereco.bairro = "Centro";
cadeira.fornecedor.endereco.cidade = "Copazio";
cadeira.fornecedor.endereco.estado = "Minas Gerais";
cadeira.fornecedor.endereco.cep = "25.674-005";


Console.WriteLine(cadeira);

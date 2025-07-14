using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Services
{
    internal class ProdutoService
    {
        private static List<Produto> produtos = new List<Produto>();
        public void Cadastrar(string nomeProduto, string codigoProduto, decimal precoProduto, Fornecedor fornecedor)
        {
            Produto produto1 = new Produto();
            produto1.SetNomeProduto(nomeProduto);
            produto1.SetCodigoProduto(codigoProduto);
            produto1.SetPrecoProduto(precoProduto);
            produto1.SetFornecedor(fornecedor);
            produtos.Add(produto1);
        }
        public void Editar()
        {

        }
        public void Listar()
        {

        }
        public void Deletar()
        {

        }
    }
}

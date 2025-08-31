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
        public int Cadastrar(string nomeProduto, string codigoProduto, decimal precoProduto, Fornecedor fornecedor)
        {
            Produto produto1 = new Produto();
            produto1.NomeProduto = nomeProduto;
            produto1.CodigoProduto = codigoProduto;
            produto1.PrecoProduto = precoProduto;
            produto1.Fornecedor = fornecedor;
            produtos.Add(produto1);

            int id = produto1.GetId();
            return id;
        }
        public void Editar()
        {

        }
        public void Listar()
        {

        }
        public Produto ListarPorId(int id)
        {
            Produto mercadoria = produtos.Find(e => e.GetId() == id);
            return mercadoria;
        }
        public void Deletar()
        {

        }
    }
}

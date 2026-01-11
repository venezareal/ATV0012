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
        public bool Editar(int id, string nomeProduto, string codigoProduto, decimal precoProduto, Fornecedor fornecedor)
        {
            Produto produto = this.ListarPorId(id);
            if (produto != null)
            {
                produto.NomeProduto = nomeProduto;
                produto.CodigoProduto = codigoProduto;
                produto.PrecoProduto = precoProduto;
                produto.Fornecedor = fornecedor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Produto> Listar()
        {
            return produtos;
        }
        public Produto ListarPorId(int id)
        {
            Produto mercadoria = produtos.Find(e => e.GetId() == id);
            return mercadoria;
        }
        public bool Deletar()
        {
            Produto produto = this.ListarPorId(id);
            if (produto != null)
            {
                produtos.Remove(produto);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

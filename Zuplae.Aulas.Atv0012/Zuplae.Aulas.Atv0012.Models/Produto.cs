using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Produto
    {
        private string nomeProduto;
        private string codigoProduto;
        private decimal precoProduto;

        public Fornecedor fornecedor;

        public void SetNomeProduto(string nomeProduto)
        {
            this.nomeProduto = nomeProduto;
        }

        public string GetNomeProduto()
        {
            return this.nomeProduto;     
        }
        public void SetCodigoProduto(string codigoProduto)
        {
            this.codigoProduto = codigoProduto;
        }

        public string GetCodigoProduto()
        {
            return this.codigoProduto;
        }

        public void SetPreco(decimal preco)
        {
            this.precoProduto = preco;
        }

        public decimal GetPreco()
        {
            return this.precoProduto;
        }

        public override string ToString()
        {
            return $"Produto: {this.nomeProduto}, Código: {this.codigoProduto}, Preço:C {this.precoProduto}";
        }
    }
}

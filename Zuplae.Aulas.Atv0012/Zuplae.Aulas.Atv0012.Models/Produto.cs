using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Produto
    {
        public Produto()
        {

        }

        public string nomeProduto;
        public string codigoProduto;
        public string precoProduto;

        public Fornecedor fornecedor;

        public override string ToString()
        {
            return $"Produto: {this.nomeProduto}, Código: {this.codigoProduto}, Preço: {this.precoProduto}";
        }
    }
}

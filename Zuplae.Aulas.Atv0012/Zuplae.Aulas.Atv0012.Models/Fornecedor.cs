using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            
        }

        public string razaoSocial;
        public string cnpj;

        public Endereco endereco;

        public override string ToString()
        {
            return $"Nome: {this.razaoSocial} - CNPJ: {this.cnpj} \nEndereço: ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Fornecedor
    {
        public string razaoSocial;
        public string cnpj;

        public Endereco endereco;

        public void SetRazaoSocial(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
        }

        public string GetRazaoSocial()
        {
            return this.razaoSocial;
        }

        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string GetCnpj()
        {
            return this.cnpj;
        }

        public void SetEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

        public Endereco GetEndereco()
        {
            return this.endereco;
        }


        public override string ToString()
        {
            return $"Nome: {this.razaoSocial} - CNPJ: {this.cnpj} \nEndereço: {this.endereco}";
        }
    }
}

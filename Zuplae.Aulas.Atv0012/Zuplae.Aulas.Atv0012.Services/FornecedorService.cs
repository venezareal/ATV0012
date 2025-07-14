using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Services
{
    public class FornecedorService
    {
        private static List<Fornecedor> fornecedores = new List<Fornecedor>();
        public void Cadastrar(string razaoSocial, string cnpj, Endereco endereco)
        {
            Fornecedor fornecedor1 = new Fornecedor();
            fornecedor1.SetRazaoSocial(razaoSocial);
            fornecedor1.SetCnpj(cnpj);
            fornecedor1.SetEndereco(endereco);
            fornecedores.Add(fornecedor1);
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

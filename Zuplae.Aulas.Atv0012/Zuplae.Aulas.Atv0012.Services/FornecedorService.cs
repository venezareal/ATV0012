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
        public int Cadastrar(string razaoSocial, string cnpj, Endereco endereco)
        {
            Fornecedor fornecedor1 = new Fornecedor();
            fornecedor1.RazaoSocial = razaoSocial;
            fornecedor1.Cnpj = cnpj;
            fornecedor1.Endereco = endereco;
            fornecedores.Add(fornecedor1);

            int id = fornecedor1.GetId();
            return id;
        }
        public void Editar()
        {

        }
        public void Listar()
        {

        }
        public Fornecedor ListarPorId(int id)
        {
            Fornecedor primario = fornecedores.Find(e => e.GetId() == id);
            return primario;
        }
        public void Deletar()
        {

        }
    }
}

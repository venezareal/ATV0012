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
            fornecedor1.SetRazaoSocial(razaoSocial);
            fornecedor1.SetCnpj(cnpj);
            fornecedor1.SetEndereco(endereco);
            fornecedores.Add(fornecedor1);

            int id = fornecedor1.GetId();
            return id;
        }
        public bool Editar(int id, string razaoSocial, string cnpj, Endereco endereco)
        {
            Fornecedor fornecedor = this.ListarPorId(id);
            if (fornecedor != null)
            {
                fornecedor.SetRazaoSocial(razaoSocial);
                fornecedor.SetCnpj(cnpj);
                fornecedor.SetEndereco(endereco);
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Fornecedor> Listar()
        {
            return fornecedores;
        }
        public Fornecedor ListarPorId(int id)
        {
            Fornecedor primario = fornecedores.Find(e => e.GetId() == id);
            return primario;
        }
        public bool Deletar(int id)
        {
            Fornecedor fornecedor = this.ListarPorId(id);
            if (fornecedor != null)
            {
                fornecedores.Remove(fornecedor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

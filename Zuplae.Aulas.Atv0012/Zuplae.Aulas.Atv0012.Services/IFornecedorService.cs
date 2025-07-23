using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Services
{
    public interface IFornecedorService
    {
        public int Cadastrar(string razaoSocial, string cnpj, Endereco endereco);
        public bool Editar(int id, string razaoSocial, string cnpj, Endereco endereco);

        List<Fornecedor> Listar();

        Fornecedor ListarPorId(int id);

        public bool Deletar(int id);
    }
}

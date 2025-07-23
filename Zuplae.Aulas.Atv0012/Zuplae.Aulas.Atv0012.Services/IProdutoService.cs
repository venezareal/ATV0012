using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Services
{
    public interface IProdutoService
    {
        public int Cadastrar(string nomeProduto, string codigoProduto, decimal precoProduto, Fornecedor fornecedor);
        public bool Editar(int id, string nomeProduto, string codigoProduto, decimal precoProduto, Fornecedor fornecedor);

        List<Produto> Listar();

        Produto ListarPorId(int id);

        public bool Deletar(int id);
    }
}

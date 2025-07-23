using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Services
{
    public interface IEnderecoService
    {
        public int Cadastrar(string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep);

        public bool Editar(int id, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep);

        List<Endereco> Listar();

        Endereco ListarPorId(int id);

        public bool Deletar(int id);




    }
}

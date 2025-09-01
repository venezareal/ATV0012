using System.Reflection.Metadata.Ecma335;
using Zuplae.Aulas.Atv0012.Models;


namespace Zuplae.Aulas.Atv0012.Services
{
    public class EnderecoService
    {
        private static List<Endereco> enderecos = new List<Endereco>();
        public int Cadastrar(string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            Endereco endereco1 = new Endereco();
            endereco1.Logradouro = logradouro;
            endereco1.Numero = numero;
            endereco1.Complemento = complemento;
            endereco1.Bairro = bairro;
            endereco1.Cidade = cidade;
            endereco1.Estado = estado;
            endereco1.Cep = cep;
            enderecos.Add(endereco1);

            int id = endereco1.GetId();
            return id;
        }
        public bool Editar(int id, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep)
        {
            Endereco endereco = this.ListarPorId(id);
            if (endereco != null)
            {
                endereco.Logradouro = logradouro;
                endereco.Numero = numero;
                endereco.Complemento = complemento;
                endereco.Bairro = bairro;
                endereco.Cidade = cidade;
                endereco.Estado = estado;
                endereco.Cep = cep;
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Endereco> Listar()
        {
            return enderecos;
        }
        public Endereco ListarPorId(int id)
        {
            Endereco end = enderecos.Find(e => e.GetId() == id);        
            return end;
        }
        public bool Deletar(int id)
        {
            Endereco endereco = this.ListarPorId(id);
            if (endereco != null)
            {
                enderecos.Remove(endereco);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
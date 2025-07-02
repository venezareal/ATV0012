namespace Zuplae.Aulas.Atv0012.Models
{
    public class Endereco
    {
        public Endereco()
        {
            
        }
        public string rua;
        public string numero;
        public string bairro;
        public string cidade;
        public string estado;
        public string cep;

        public override string ToString()
        {
            return $"Rua {this.rua}, Nº {this.numero}, Bairro {this.bairro}, \nCidade: {this.cidade}, Estado {this.estado}, \nCEP: {this.cep}";
        }
    }
}

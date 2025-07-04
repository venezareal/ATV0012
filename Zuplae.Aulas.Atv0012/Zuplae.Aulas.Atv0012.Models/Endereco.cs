namespace Zuplae.Aulas.Atv0012.Models
{
    public class Endereco
    {
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        public Endereco()
        {
            
        }
        public void SetRua(string rua)
        {
            this.rua = rua;
        }
        public string GetRua()
        {
            return this.rua;
        }
        public void SetNumero(string numero)
        {
            this.numero = numero;
        }
        public string GetNumero()
        {
            return this.numero;
        }

        public void SetBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string GetBairro()
        {
            return this.bairro;
        }
        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string GetCidade()
        {
            return this.cidade;
        }

        public void SetEstado(string estado)
        {
            this.estado = estado;
        }

        public string GetEstado()
        {
            return this.estado;
        }

        public void SetCep(string cep)
        {
            this.cep = cep;
        }

        public string GetCep()
        {
            return this.cep;
        }

        public override string ToString()
        {
            return $"\nRua {this.rua}, Nº {this.numero}, Bairro {this.bairro}, \nCidade: {this.cidade}, Estado {this.estado}, \nCEP: {this.cep}";
        }
    }
}

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Endereco : BaseModel
    {
        #region Propriedades
            public string Logradouro { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Cep { get; set; }
        #endregion
        #region MetodosGetSet
            
        #endregion
        #region ImpressaoToString
            public override string ToString()
            {
                return $"\nRua {this.GetRua}, Nº {this.GetNumero}, Complemento: {this.complemento}, Bairro: {this.GetBairro}, \nCidade: {this.GetCidade}, Estado: {this.GetEstado}, \nCEP: {this.GetCep}";
            }
        #endregion
    }
}

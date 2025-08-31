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
       
        #region ImpressaoToString
            public override string ToString()
            {
                return $"\nRua {Logradouro}, Nº {Numero}, Complemento: {Complemento}, Bairro: {Bairro}, \nCidade: {Cidade}, Estado: {Estado}, \nCEP: {Cep}";
            }
        #endregion
    }
}

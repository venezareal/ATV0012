using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Fornecedor : BaseModel
    {
        #region CamposPrivados

            public string RazaoSocial { get; set; }
            public string Cnpj { get; set; }
            public Endereco Endereco { get; set; }
        #endregion
        #region ImpressaoToString
            public override string ToString()
            {
                return $"Nome: {RazaoSocial} - CNPJ: {Cnpj} \nEndereço: {Endereco}";
            }
        #endregion
    }
}

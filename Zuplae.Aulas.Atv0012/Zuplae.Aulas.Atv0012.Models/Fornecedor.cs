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

            private string razaoSocial;
            private string cnpj;
            private Endereco endereco;
        #endregion
        #region MetodosGetSet
            public void SetRazaoSocial(string razaoSocial)
            {
                this.razaoSocial = razaoSocial;
            }
            public string GetRazaoSocial()
            {
                return this.razaoSocial;
            }
            public void SetCnpj(string cnpj)
            {
                this.cnpj = cnpj;
            }
            public string GetCnpj()
            {
                return this.cnpj;
            }
            public void SetEndereco(Endereco endereco)
            {
                this.endereco = endereco;
            }
            public Endereco GetEndereco()
            {
                return this.endereco;
            }
        #endregion
        #region ImpressaoToString
            public override string ToString()
            {
                return $"Nome: {this.GetRazaoSocial} - CNPJ: {this.GetCnpj} \nEndereço: {this.GetEndereco}";
            }
        #endregion
    }
}

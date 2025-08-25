using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Produto : BaseModel
    {
        #region CamposPrivados
            public string NomeProduto { get; set; }
            public string CodigoProduto { get; private set; }
            public decimal PrecoProduto { get; set; }
            public Fornecedor Fornecedor { get; set; }
        #endregion
        #region MetodosGetSet
            public void SetNomeProduto(string nomeProduto)
            {
                this.nomeProduto = nomeProduto;
            }
            public string GetNomeProduto()
            {
                return this.nomeProduto.toupper;     
            }
            public void SetCodigoProduto(string codigoProduto)
            {
                this.codigoProduto = codigoProduto;
            }
            public string GetCodigoProduto()
            {
                return this.codigoProduto;
            }
            public void SetPrecoProduto(decimal preco)
            {
                this.precoProduto = preco;
            }
            public decimal GetPrecoProduto()
            {
                return this.precoProduto;
            }
            public void SetFornecedor(Fornecedor fornecedor){
                this.fornecedor = fornecedor;
            }
            public Fornecedor GetFornecedor() {
                return this.fornecedor;
            }
        #endregion
        #region ImpressaoToString
           public override string ToString()
            {
                return $"Produto: {this.GetNomeProduto}, Código: {this.GetCodigoProduto}, Preço:C {this.GetPrecoProduto}, \nFornecedor: {this.GetFornecedor}";
            }
        #endregion
    }
}

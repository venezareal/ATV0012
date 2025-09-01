using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class Produto : BaseModel
    {
        #region Propriedades
            private string _nome;
            public string NomeProduto {
                get { return this._nome.ToUpper(); }
                set { this._nome = value; } 
            }
            
            private decimal _preco;
            public decimal PrecoProduto { 
                get { return _preco; }
                set {
                if (value < 0 || value > 100.00m) 
                {
                    throw new Exception("Preço deve estar entre R$ 0,00 e R$ 100,00.");
                    
                }
                    this._preco = value;
                
                } 
            }
             public string CodigoProduto { get; private set; }

             public Fornecedor Fornecedor { get; set; }
        #endregion
        #region Construtores
            public Produto() 
            {
                this.GerarCodigo();
            }
            public Produto(string nome, decimal preco, Fornecedor fornecedor) 
            {
                this.NomeProduto = nome;
                this.PrecoProduto = preco;
                this.Fornecedor = fornecedor;

                this.GerarCodigo();
            }
      
           
        #endregion
        #region ImpressaoToString
           public override string ToString()
            {
                return $"Produto: {NomeProduto}, Código: {CodigoProduto}, Preço:C {PrecoProduto}, \nFornecedor: {Fornecedor}";
            }
            public void GerarCodigo() 
            {
                CodigoProduto = "ZPEL" + Guid.NewGuid().ToString("N").Substring(0,8).ToUpper();
            }
        #endregion
    }
}

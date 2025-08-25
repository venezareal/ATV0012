using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0012.Models
{
    public class BaseModel
    {
        #region Campos Privados
            private static int id;

        #endregion
        #region Id
            public void SetId(int id)
            {
                id = id;
            }
            public int GetId()
            {
                return this.id;
            }
        #endregion
        #region Construtor
            public BaseModel()
            {
                id++;
            }
        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Application.T_Prestatario.Queries.GetPrestatarioByDocument
{
    public interface IGetPrestatarioByDocumentQuery
    {
        Data.T_Prestatario Execute(int TipoDocumento, string NumeroDocumento);
    }
}

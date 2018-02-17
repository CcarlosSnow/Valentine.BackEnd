using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentine.Data;

namespace Valentine.Application.T_Parametro.Queries.GetParametroByIdPadre
{
    public interface IGetParametroByIdPadreQuery
    {
        List<Data.T_Parametro> Execute(int PadreID);
    }
}

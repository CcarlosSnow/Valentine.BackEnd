using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Application.T_Ubigeo.Queries.GetUbigeoByIdPadre
{
    public interface IGetUbigeoByIdPadreQuery
    {
        List<Data.T_Ubigeo> Execute(int PadreID);
    }
}

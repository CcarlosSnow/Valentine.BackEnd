using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentine.Data;

namespace Valentine.Application.T_Parametro.Queries.GetParametroByIdPadre
{
    public class GetParametroByIdPadreQuery : IGetParametroByIdPadreQuery
    {
        private ValentineEntities _Entities;
        public GetParametroByIdPadreQuery()
        {
        }

        public List<Data.T_Parametro> Execute(int PadreID)
        {
            using (_Entities = new ValentineEntities())
            {
                var Result = _Entities.T_Parametro.Where(s => s.Padre == PadreID).ToList();

                return Result;
            }
        }
    }
}

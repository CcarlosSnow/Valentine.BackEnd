using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentine.Data;

namespace Valentine.Application.T_Ubigeo.Queries.GetUbigeoByIdPadre
{
    public class GetUbigeoByIdPadreQuery : IGetUbigeoByIdPadreQuery
    {
        private ValentineEntities _Entities;
        public GetUbigeoByIdPadreQuery()
        {
        }

        public List<Data.T_Ubigeo> Execute(int PadreID)
        {
            using (_Entities = new ValentineEntities())
            {
                if (PadreID == 0)
                {
                    var Result = _Entities.T_Ubigeo.Where(s => s.Ubigeo_Padre == null).ToList();

                    return Result;
                }
                else
                {
                    var Result = _Entities.T_Ubigeo.Where(s => s.Ubigeo_Padre == PadreID).ToList();

                    return Result;
                }
            }
        }
    }
}


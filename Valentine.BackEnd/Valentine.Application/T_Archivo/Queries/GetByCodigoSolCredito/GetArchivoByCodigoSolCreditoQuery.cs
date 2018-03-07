using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentine.Data;

namespace Valentine.Application.T_Archivo.Queries.GetByCodigoSolCredito
{
    public class GetArchivoByCodigoSolCreditoQuery : IGetArchivoByCodigoSolCreditoQuery
    {
        private ValentineEntities _Entities;

        public GetArchivoByCodigoSolCreditoQuery()
        {

        }
        public List<Data.T_Archivo> Execute(int CodigoSolCredito)
        {
            using (_Entities = new ValentineEntities())
            {
                var Result = _Entities.T_Archivo.Where(A => A.codigoSolCredito == CodigoSolCredito).ToList();
                return Result;
            }
        }
    }
}

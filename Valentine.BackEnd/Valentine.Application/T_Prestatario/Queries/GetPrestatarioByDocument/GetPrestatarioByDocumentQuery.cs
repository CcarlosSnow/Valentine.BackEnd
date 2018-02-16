using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentine.Data;

namespace Valentine.Application.T_Prestatario.Queries.GetPrestatarioByDocument
{
    public class GetPrestatarioByDocumentQuery : IGetPrestatarioByDocumentQuery
    {
        private ValentineEntities _Entities;
        public GetPrestatarioByDocumentQuery()
        {
        }

        public Data.T_Prestatario Execute(int TipoDocumento, string NumeroDocumento)
        {
            using (_Entities = new ValentineEntities())
            {
                var Result = _Entities.T_Prestatario.Where(s => s.tipoDocumento == TipoDocumento && s.numeroDocumento == NumeroDocumento).FirstOrDefault();

                //var Result = Mapper.Map<GetSolicitudCreditoQueryModel>(ResultQuery);

                return Result;
            }
        }
    }
}

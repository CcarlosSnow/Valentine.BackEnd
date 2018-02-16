using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentine.Data;

namespace Valentine.Application.T_SolicitudCredito.Queries.GetSolicitudCredito
{
    public class GetSolicitudCreditoQuery : IGetSolicitudCreditoQuery
    {
        private ValentineEntities _Entities;
        public GetSolicitudCreditoQuery()
        {
        }

        public Data.T_SolicitudCredito Execute(int ID)
        {
            using (_Entities = new ValentineEntities())
            {
                var Result = _Entities.T_SolicitudCredito.Where(s => s.codigoSolCredito == ID).FirstOrDefault();

                //var Result = Mapper.Map<GetSolicitudCreditoQueryModel>(ResultQuery);

                return Result;
            }
        }
    }
}

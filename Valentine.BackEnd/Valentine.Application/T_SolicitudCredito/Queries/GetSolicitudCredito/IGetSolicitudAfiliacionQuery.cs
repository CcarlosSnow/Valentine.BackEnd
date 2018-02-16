using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Application.T_SolicitudCredito.Queries.GetSolicitudCredito
{
    public interface IGetSolicitudCreditoQuery
    {
        Data.T_SolicitudCredito Execute(int ID);
    }
}

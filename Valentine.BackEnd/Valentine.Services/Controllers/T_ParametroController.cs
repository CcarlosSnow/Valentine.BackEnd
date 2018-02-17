using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Valentine.Application.T_Parametro.Queries.GetParametroByIdPadre;
using Valentine.Data;

namespace Valentine.Services.Controllers
{
    public class T_ParametroController : ApiController
    {
        private IGetParametroByIdPadreQuery _IGetParametroByIdPadreQuery;
        public T_ParametroController(IGetParametroByIdPadreQuery IGetParametroByIdPadreQuery)
        {
            _IGetParametroByIdPadreQuery = IGetParametroByIdPadreQuery;
        }

        public List<T_Parametro> GetByPadreID(int id)
        {
            return _IGetParametroByIdPadreQuery.Execute(id);
        }
    }
}
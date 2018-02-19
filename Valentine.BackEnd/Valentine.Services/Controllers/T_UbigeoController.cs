using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Valentine.Application.T_Ubigeo.Queries.GetUbigeoByIdPadre;
using Valentine.Data;

namespace Valentine.Services.Controllers
{
    public class T_UbigeoController : ApiController
    {
        private IGetUbigeoByIdPadreQuery _IGetUbigeoByIdPadreQuery;
        public T_UbigeoController(IGetUbigeoByIdPadreQuery IGetUbigeoByIdPadreQuery)
        {
            _IGetUbigeoByIdPadreQuery = IGetUbigeoByIdPadreQuery;
        }

        public List<T_Ubigeo> GetByPadreID(int id)
        {
            return _IGetUbigeoByIdPadreQuery.Execute(id);
        }
    }
}
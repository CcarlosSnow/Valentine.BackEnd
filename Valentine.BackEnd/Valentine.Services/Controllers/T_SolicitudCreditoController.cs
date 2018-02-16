using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Valentine.Application.T_SolicitudCredito.Commands.RegisterFirstStep;
using Valentine.Application.T_SolicitudCredito.Commands.RegisterSecondStep;

namespace Valentine.Services.Controllers
{
    public class T_SolicitudCreditoController : ApiController
    {
        private IRegisterFirstStepCommand _IRegisterFirstStepCommand;
        private IRegisterSecondStepCommand _IRegisterSecondStepCommand;
        public T_SolicitudCreditoController(IRegisterFirstStepCommand IRegisterFirstStepCommand, IRegisterSecondStepCommand IRegisterSecondStepCommand)
        {
            _IRegisterFirstStepCommand = IRegisterFirstStepCommand;
            _IRegisterSecondStepCommand = IRegisterSecondStepCommand;
        }

        [ResponseType(typeof(RegisterFirstStepCommandModel))]
        public IHttpActionResult PostT_SolicitudCreditoFirstStep(RegisterFirstStepCommandModel model)
        {
            var Result = _IRegisterFirstStepCommand.Execute(model);

            return Created(Request.RequestUri, Result);
        }

        [ResponseType(typeof(RegisterFirstStepCommandModel))]
        public IHttpActionResult PutT_SolicitudCreditoSecondStep(int id, RegisterSecondStepCommandModel model)
        {
            var Result = _IRegisterSecondStepCommand.Execute(id, model);

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
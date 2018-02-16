using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Application.T_SolicitudCredito.Commands.RegisterFirstStep
{
    public interface IRegisterFirstStepCommand
    {
        RegisterFirstStepCommandModel Execute(RegisterFirstStepCommandModel Model);
    }
}

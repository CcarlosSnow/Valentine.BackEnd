using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Application.T_SolicitudCredito.Commands.RegisterSecondStep
{
    public interface IRegisterSecondStepCommand
    {
        RegisterSecondStepCommandModel Execute(int ID, RegisterSecondStepCommandModel Model);
    }
}

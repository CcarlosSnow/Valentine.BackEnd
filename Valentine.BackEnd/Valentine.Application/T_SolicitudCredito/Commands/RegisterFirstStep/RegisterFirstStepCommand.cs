using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Valentine.Data;

namespace Valentine.Application.T_SolicitudCredito.Commands.RegisterFirstStep
{
    public class RegisterFirstStepCommand : IRegisterFirstStepCommand
    {
        private ValentineEntities _Entities;

        public RegisterFirstStepCommand()
        {
            
        }
        public RegisterFirstStepCommandModel Execute(RegisterFirstStepCommandModel Model)
        {
            using (_Entities = new ValentineEntities())
            {
                var _T_SolicitudCredito = Mapper.Map<Data.T_SolicitudCredito>(Model);
                _Entities.T_SolicitudCredito.Add(_T_SolicitudCredito);
                _Entities.SaveChanges();

                var Result = Mapper.Map<RegisterFirstStepCommandModel>(_T_SolicitudCredito);

                return Result;
            }
        }
    }
}

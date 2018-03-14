using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentine.Data;
using Valentine.Application.T_SolicitudCredito.Queries.GetSolicitudCredito;
using AutoMapper;
using System.Data.Entity;
using System.Net.Mail;
using System.Net;

namespace Valentine.Application.T_SolicitudCredito.Commands.RegisterSecondStep
{
    public class RegisterSecondStepCommand : IRegisterSecondStepCommand
    {
        private ValentineEntities _Entities;

        public RegisterSecondStepCommand()
        {
        }

        public RegisterSecondStepCommandModel Execute(int ID, RegisterSecondStepCommandModel Model)
        {
            using (_Entities = new ValentineEntities())
            {
                var _T_SolicitudCredito = _Entities.T_SolicitudCredito.Where(s => s.codigoSolCredito == ID).FirstOrDefault();

                Mapper.Map(Model, _T_SolicitudCredito);

                _Entities.T_SolicitudCredito.Attach(_T_SolicitudCredito);
                _Entities.Entry(_T_SolicitudCredito).State = EntityState.Modified;
                _Entities.SaveChanges();

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("valentinebackemail@gmail.com", "valentinepassword"),
                    EnableSsl = true
                };

                client.Send("valentinebackemail@gmail.com", _T_SolicitudCredito.correoElectronico, "test", "testbody");

                return Model;
            }
        }
    }
}

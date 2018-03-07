using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentine.Data;

namespace Valentine.Application.T_Archivo.Commands.UploadFile
{
    public class UploadFileCommand : IUploadFileCommand
    {
        private ValentineEntities _Entities;

        public UploadFileCommand()
        {

        }
        public Data.T_Archivo Execute(Data.T_Archivo Model)
        {
            using (_Entities = new ValentineEntities())
            {
                _Entities.T_Archivo.Add(Model);
                _Entities.SaveChanges();

                return Model;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valentine.Data;

namespace Valentine.Application.T_Archivo.Commands.UploadFile
{
    public interface IUploadFileCommand
    {
        Data.T_Archivo Execute(Data.T_Archivo Model);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Valentine.Application.T_Archivo.Commands.UploadFile;
using Valentine.Application.T_Archivo.Queries.GetByCodigoSolCredito;
using Valentine.Services.Common.Model;

namespace Valentine.Services.Controllers
{
    public class T_ArchivoController : ApiController
    {
        private IUploadFileCommand _IUploadFileCommand;
        private IGetArchivoByCodigoSolCreditoQuery _IGetArchivoByCodigoSolCreditoQuery;

        public T_ArchivoController(IUploadFileCommand IUploadFileCommand, IGetArchivoByCodigoSolCreditoQuery IGetArchivoByCodigoSolCreditoQuery)
        {
            _IUploadFileCommand = IUploadFileCommand;
            _IGetArchivoByCodigoSolCreditoQuery = IGetArchivoByCodigoSolCreditoQuery;
        }

        [ResponseType(typeof(Data.T_Archivo))]
        public IHttpActionResult PostT_Archivo(Data.T_Archivo model)
        {
            var Result = _IUploadFileCommand.Execute(model);

            return Created(Request.RequestUri, Result);
        }

        public List<Data.T_Archivo> GetByCodigoSolCredito(int id)
        {
            return _IGetArchivoByCodigoSolCreditoQuery.Execute(id);
        }

        [ResponseType(typeof(List<UploadFileModel>))]
        public IHttpActionResult PutT_ArchivoUploadFile(List<UploadFileModel> uploadFileModel)
        {
            foreach (var item in uploadFileModel)
            {
                Guid guid = Guid.NewGuid();

                string FileType = item.Extension;

                byte[] FileArray = Convert.FromBase64String(item.File.Substring(item.File.IndexOf(',') + 1));

                item.Name = StorageHelper.UploadAsync(item.Container, guid.ToString() + "." + FileType, FileArray);

                Data.T_Archivo model = new Data.T_Archivo();
                model.codigoSolCredito = item.SolicitudCreditoId;
                model.rutaArchivo = item.Name;

                _IUploadFileCommand.Execute(model);
            }

            return Ok(uploadFileModel);
        }
    }
}

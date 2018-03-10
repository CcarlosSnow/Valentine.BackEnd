using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Valentine.Services.Common.Model
{
    public class UploadFileModel
    {
        public string Container { get; set; }
        public string Name { get; set; }
        public string File { get; set; }
        public string Extension { get; set; }
        public int SolicitudCreditoId { get; set; }
    }
}
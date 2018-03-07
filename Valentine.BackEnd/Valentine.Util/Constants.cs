using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Util
{
    public class Constants
    {
        public enum Parameters
        {
            Sexo = 1,
            GradoInstruccion = 4,
            DestinoCredito = 10
        }

        public struct ContainerType
        {
            public static List<string> ContainerTypes = new List<string>() { Documentos };
            public const string Documentos = "documentos";
        }

        public struct StorageSettings
        {
            public const double StartTime = -5;
            public const double ExpiryTime = 30;
            public const string StorageAccount = "valentine";
        }
    }
}

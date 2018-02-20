using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Application.T_SolicitudCredito.Commands.RegisterFirstStep
{
    public class RegisterFirstStepCommandModel
    {
        public int codigoSolCredito { get; set; }
        public string nombreSolicitante { get; set; }

        public string apellidoParternoSolicitante { get; set; }

        public string apellidoMaternoSolicitante { get; set; }

        public string fechaNacimiento { get; set; }

        public int tipoDocumento { get; set; }

        public string numeroDocumento { get; set; }

        public string digitoVerificacion { get; set; }

        public int genero { get; set; }

        public string correoElectronico { get; set; }

        public string numeroCelular { get; set; }

        public double ingresosMensuales { get; set; }

        public int gradoInstruccion { get; set; }

        public int destinoCredito { get; set; }
    }
}

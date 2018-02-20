using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Application.T_SolicitudCredito.Commands.RegisterSecondStep
{
    public class RegisterSecondStepCommandModel
    {
        public string direccionSolicitante { get; set; }

        public string codigoPostalSolicitante { get; set; }

        public int pais { get; set; }

        public int departamento { get; set; }

        public int provincia { get; set; }

        public int distrito { get; set; }

        public double montoSolicitado { get; set; }

        public int plazoPrestamo { get; set; }

        public string seguroDesgravamen { get; set; }

        public int estadoCivil { get; set; }

        public string detalleMotivo { get; set; }

        public string apellidoPaternoConyuge { get; set; }

        public string apellidoMaternoConyuge { get; set; }

        public string nombresConyuge { get; set; }

        public int tipoDocumentoConyuge { get; set; }

        public string numeroDocConyuge { get; set; }

        public int tipoActividad { get; set; }

        public int rubroActividad { get; set; }

        public string lugarTrabajo { get; set; }

        public int tipoCuenta { get; set; }

        public int banco { get; set; }

        public string cuentaInterbancaria { get; set; }

        public bool esPEP { get; set; }

        public string cargoPEP { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valentine.Application.T_SolicitudCredito.Queries.GetSolicitudCredito
{
    public class GetSolicitudCreditoQueryModel
    {
        public int codigoSolCredito { get; set; }
        public string nombreSolicitante { get; set; }
        public string apellidoPaternoSolicitante { get; set; }
        public string apellidoMaternoSolicitante { get; set; }
        public int? tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string digitoVerificacion { get; set; }
        public string correoElectronico { get; set; }
        public string numeroCelular { get; set; }
        public string fechaNacimiento { get; set; }
        public int? genero { get; set; }
        public int? gradoInstruccion { get; set; }
        public int? estadoCivil { get; set; }
        public double? ingresoMensual { get; set; }
        public string direccionSolicitante { get; set; }
        public int? distritoSolicitante { get; set; }
        public int? provinciaSolicitante { get; set; }
        public int? dptoSolicitante { get; set; }
        public int? paisSolicitante { get; set; }
        public int? areaActividad { get; set; }
        public int? ocupacion { get; set; }
        public string lugarTrabajo { get; set; }
        public string destinoCredito { get; set; }
        public string nombreConyuge { get; set; }
        public string apellidoPaternoConyuge { get; set; }
        public string apellidoMaternoConyuge { get; set; }
        public int? tipoDocumentoConyuge { get; set; }
        public string numeroDocConyuge { get; set; }
        public double? montoSolicitado { get; set; }
        public string detalleMotivo { get; set; }
        public bool? esPEP { get; set; }
        public string cargoPEP { get; set; }
        public int? tipoCuenta { get; set; }
        public int? nombreEntidad { get; set; }
        public string codigoInterbancario { get; set; }
        public string seguroDesgravamen { get; set; }
        public int? plazoPrestamo { get; set; }
        public string dniValido { get; set; }
        public string ingresoAcorde { get; set; }
        public string sobreEndeudado { get; set; }
        public string conyugeAcorde { get; set; }
        public string creditoActual { get; set; }
        public string historialCrediticioAcorde { get; set; }
        public string perfilSolicitante { get; set; }
        public double? teaAsignada { get; set; }
        public string puntuacionBuro { get; set; }
        public string resultadoEvaluacion { get; set; }
        public string estado { get; set; }
        public int? codigoPrestatario { get; set; }
        public string codigoPostal { get; set; }
    }
}

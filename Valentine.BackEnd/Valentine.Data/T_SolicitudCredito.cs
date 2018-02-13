//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestMultiplica.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_SolicitudCredito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_SolicitudCredito()
        {
            this.T_Prestamo = new HashSet<T_Prestamo>();
            this.T_Subasata = new HashSet<T_Subasata>();
        }
    
        public string codigoSolCredito { get; set; }
        public string nombreSolicitante { get; set; }
        public string apellidosSolicitante { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string digtitoVerificacion { get; set; }
        public string correoElectronico { get; set; }
        public string numeroCelular { get; set; }
        public short fechaNacimiento { get; set; }
        public string genero { get; set; }
        public string gradoInstruccion { get; set; }
        public string estadoCivil { get; set; }
        public double ingresoMensual { get; set; }
        public string direccionSolicitante { get; set; }
        public string distritoSolicitante { get; set; }
        public string provinciaSolicitante { get; set; }
        public string dptoSolicitante { get; set; }
        public string paisSolicitante { get; set; }
        public string areaActividad { get; set; }
        public string ocupacion { get; set; }
        public string lugarTrabajo { get; set; }
        public string destinoCredito { get; set; }
        public string nombreConyuge { get; set; }
        public string numeroDocConyuge { get; set; }
        public double montoSolicitado { get; set; }
        public string detalleMotivo { get; set; }
        public double esPEP { get; set; }
        public string cargoPEP { get; set; }
        public string tipoCuenta { get; set; }
        public string nombreEntidad { get; set; }
        public string codigoInterbancario { get; set; }
        public string seguroDesgravamen { get; set; }
        public string plazoPrestamo { get; set; }
        public string dniValido { get; set; }
        public string ingresoAcorde { get; set; }
        public string sobreEndeudado { get; set; }
        public string conyugeAcorde { get; set; }
        public string creditoActual { get; set; }
        public string historialCrediticioAcorde { get; set; }
        public string perfilSolicitante { get; set; }
        public double teaAsignada { get; set; }
        public string puntuacionBuro { get; set; }
        public string resultadoEvaluacion { get; set; }
        public string estado { get; set; }
        public string codigoPrestatario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Prestamo> T_Prestamo { get; set; }
        public virtual T_Prestatario T_Prestatario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Subasata> T_Subasata { get; set; }
    }
}

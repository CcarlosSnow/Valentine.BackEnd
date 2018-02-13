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
    
    public partial class T_Inversor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Inversor()
        {
            this.T_Cuenta = new HashSet<T_Cuenta>();
            this.T_Oferta = new HashSet<T_Oferta>();
            this.T_SolicitudAfiliacion = new HashSet<T_SolicitudAfiliacion>();
        }
    
        public string codigoInversor { get; set; }
        public string nombresInversor { get; set; }
        public string apellidosInversor { get; set; }
        public short fechaNacimiento { get; set; }
        public string paisResidencia { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string modoInversion { get; set; }
        public string tipo { get; set; }
        public double conContratoMandato { get; set; }
        public double comisionCobrada { get; set; }
        public double rentabilidadMinima { get; set; }
        public double rentabilidadMaxima { get; set; }
        public double ofertaMinima { get; set; }
        public double ofertaMaxima { get; set; }
        public string destinoCredito { get; set; }
        public int edadMinima { get; set; }
        public int edadMaxima { get; set; }
        public short fechaIngreso { get; set; }
        public string correoElectronico { get; set; }
        public string numeroCelular { get; set; }
        public string genero { get; set; }
        public string direccion { get; set; }
        public string distrito { get; set; }
        public string provincia { get; set; }
        public string departamento { get; set; }
        public string codigoPostal { get; set; }
        public string areaActividad { get; set; }
        public string rubroActividad { get; set; }
        public string esPEP { get; set; }
        public string codigoInterbancario { get; set; }
        public string codigoPrestatario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Cuenta> T_Cuenta { get; set; }
        public virtual T_Prestatario T_Prestatario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Oferta> T_Oferta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SolicitudAfiliacion> T_SolicitudAfiliacion { get; set; }
    }
}

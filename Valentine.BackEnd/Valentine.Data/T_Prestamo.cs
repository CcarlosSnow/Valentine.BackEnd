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
    
    public partial class T_Prestamo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Prestamo()
        {
            this.T_Cuota = new HashSet<T_Cuota>();
            this.T_Subasata = new HashSet<T_Subasata>();
        }
    
        public int codigoPrestamo { get; set; }
        public double montoTransferido { get; set; }
        public double tea { get; set; }
        public int plazo { get; set; }
        public bool conContratoPrestamo { get; set; }
        public short fechaFormalizacion { get; set; }
        public short fechaDesembolso { get; set; }
        public double vigente { get; set; }
        public string numeroInstruccion { get; set; }
        public string cuentaOrigen { get; set; }
        public string cuentaDesting { get; set; }
        public string tipoOperacion { get; set; }
        public short fechaOperacion { get; set; }
        public string numeroTransferencia { get; set; }
        public int codigoPrestatario { get; set; }
        public int codigoSolCredito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Cuota> T_Cuota { get; set; }
        public virtual T_Prestatario T_Prestatario { get; set; }
        public virtual T_SolicitudCredito T_SolicitudCredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Subasata> T_Subasata { get; set; }
    }
}
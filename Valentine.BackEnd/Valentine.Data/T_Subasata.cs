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
    
    public partial class T_Subasata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Subasata()
        {
            this.T_Oferta = new HashSet<T_Oferta>();
        }
    
        public int codigoSubasta { get; set; }
        public short fechaInicio { get; set; }
        public short fechaTermino { get; set; }
        public double montoRecaudado { get; set; }
        public short fechaCorreoResultado { get; set; }
        public short fechaAceptacion { get; set; }
        public double montoAceptado { get; set; }
        public Nullable<int> codigoPrestamo { get; set; }
        public int codigoSolCredito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Oferta> T_Oferta { get; set; }
        public virtual T_Prestamo T_Prestamo { get; set; }
        public virtual T_SolicitudCredito T_SolicitudCredito { get; set; }
    }
}
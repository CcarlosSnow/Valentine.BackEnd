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
    
    public partial class T_PagoDetalle
    {
        public double montoCuota { get; set; }
        public string codigoPrestamo { get; set; }
        public string codigoCuota { get; set; }
        public string codigoPago { get; set; }
        public string codigoConcepto { get; set; }
    
        public virtual T_Concepto T_Concepto { get; set; }
        public virtual T_Cuota T_Cuota { get; set; }
        public virtual T_Pago T_Pago { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valentine.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Oferta
    {
        public int codigoOferta { get; set; }
        public double montoOfertado { get; set; }
        public double teaOfertada { get; set; }
        public short fecha { get; set; }
        public bool ofertaAdmitida { get; set; }
        public int codigoSubasta { get; set; }
        public int codigoInversor { get; set; }
        public int codigoPrestatario { get; set; }
    
        public virtual T_Inversor T_Inversor { get; set; }
        public virtual T_Subasata T_Subasata { get; set; }
    }
}

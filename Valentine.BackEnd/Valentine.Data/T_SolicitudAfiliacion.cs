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
    
    public partial class T_SolicitudAfiliacion
    {
        public string codigoSolAfiliacion { get; set; }
        public string nombresInversor { get; set; }
        public string apellidosInversor { get; set; }
        public string numeroCelular { get; set; }
        public string correoElectronico { get; set; }
        public short fechaNacimiento { get; set; }
        public string genero { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string paisResidencia { get; set; }
        public string direccion { get; set; }
        public string distrito { get; set; }
        public string provincia { get; set; }
        public string departamento { get; set; }
        public string codigoPostal { get; set; }
        public string areaActividad { get; set; }
        public string rubroActividad { get; set; }
        public bool esPEP { get; set; }
        public short codigoInterbancario { get; set; }
        public string clave { get; set; }
        public short fechaPresentacion { get; set; }
        public string estado { get; set; }
        public string codigoInversor { get; set; }
        public string codigoPrestatario { get; set; }
    
        public virtual T_Inversor T_Inversor { get; set; }
    }
}

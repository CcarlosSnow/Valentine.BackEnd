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
    
    public partial class T_Usuario
    {
        public int codigoUsuario { get; set; }
        public short fechaAlta { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int codigoPerfil { get; set; }
    
        public virtual T_Perfil T_Perfil { get; set; }
    }
}

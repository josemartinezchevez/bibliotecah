//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliotecah
{
    using System;
    using System.Collections.Generic;
    
    public partial class Historiales
    {
        public long PkID_Historial { get; set; }
        public int FkID_Usuario { get; set; }
        public int FKID_Operacion { get; set; }
        public long FKID_Archivo { get; set; }
        public System.DateTime Fecha_Historial { get; set; }
        public string Observacion { get; set; }
    
        public virtual Archivos Archivos { get; set; }
        public virtual Operaciones Operaciones { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}

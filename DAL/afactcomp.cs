//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class afactcomp
    {
        public int cia { get; set; }
        public int activo { get; set; }
        public int secuencia { get; set; }
        public string descrip { get; set; }
        public string serie { get; set; }
        public string usuario { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public System.DateTime hora_creacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
    
        public virtual afactivo afactivo { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd_Pismire
{
    using System;
    using System.Collections.Generic;
    
    public partial class recomendados_empresa
    {
        public int IdRecomendadosEmpresa { get; set; }
        public string FK_usuario_empresa { get; set; }
        public int FK_curriculo { get; set; }
    
        public virtual curriculo curriculo { get; set; }
        public virtual usuario_empresa usuario_empresa { get; set; }
    }
}

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
    
    public partial class candidatos
    {
        public int idCandidatos { get; set; }
        public System.DateTime dataInscricao { get; set; }
        public System.TimeSpan horaInscricao { get; set; }
        public int FK_evento { get; set; }
        public string FK_usuario_trabalhador { get; set; }
    
        public virtual evento evento { get; set; }
        public virtual usuario_trabalhador usuario_trabalhador { get; set; }
    }
}

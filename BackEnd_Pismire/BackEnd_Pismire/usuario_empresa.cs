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
    
    public partial class usuario_empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario_empresa()
        {
            this.avaliacao = new HashSet<avaliacao>();
            this.evento = new HashSet<evento>();
            this.interessados_empresa = new HashSet<interessados_empresa>();
            this.perfil_empresa = new HashSet<perfil_empresa>();
            this.recomendados_empresa = new HashSet<recomendados_empresa>();
            this.recomendados_trabalhador = new HashSet<recomendados_trabalhador>();
        }
    
        public string cnpj { get; set; }
        public string areaEmpresa { get; set; }
        public int FK_usuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<avaliacao> avaliacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evento> evento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<interessados_empresa> interessados_empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<perfil_empresa> perfil_empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recomendados_empresa> recomendados_empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recomendados_trabalhador> recomendados_trabalhador { get; set; }
        public virtual usuario usuario { get; set; }
    }
}

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
    
    public partial class perfil_empresa
    {
        public int idPerfilEmpresa { get; set; }
        public string site { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string facebookEmpresa { get; set; }
        public string estadoEmpresa { get; set; }
        public string cidadeEmpresa { get; set; }
        public string bairroEmpresa { get; set; }
        public string ruaEmpresa { get; set; }
        public string numeroEmpresa { get; set; }
        public string cepEmpresa { get; set; }
        public byte[] fotoEmpresa { get; set; }
        public string descricaoEmpresa { get; set; }
        public string FK_usuario_empresa { get; set; }
    
        public virtual usuario_empresa usuario_empresa { get; set; }
    }
}

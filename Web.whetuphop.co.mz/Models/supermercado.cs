//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.whetuphop.co.mz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class supermercado
    {
        public int supermercado_id { get; set; }
        public string slug { get; set; }
        public string nome_completo { get; set; }
        public string nome_curto { get; set; }
        public Nullable<int> endereco_id { get; set; }
        public bool isActive { get; set; }
    
        public virtual endereco endereco { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiEletroposto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoas()
        {
            this.Simulacoes = new HashSet<Simulacoes>();
        }
    
        public int id { get; set; }
        public string TipodePessoa { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Nullable<int> Situacao { get; set; }
        public Nullable<System.DateTime> DatadeCriacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Simulacoes> Simulacoes { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Churra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Churra()
        {
            this.Participantes = new HashSet<Participante>();
        }
    
        public int Id { get; set; }
        public System.DateTime Data { get; set; }
        public string Motivo { get; set; }
        public string Observacao { get; set; }
        public Nullable<decimal> ValorComBebida { get; set; }
        public Nullable<decimal> ValorSemBebida { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participante> Participantes { get; set; }
    }
}

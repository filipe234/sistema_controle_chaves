//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Controle_Chave_Negocio.Persistencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo_Setor_BD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Setor_BD()
        {
            this.TB_CAD_SETOR = new HashSet<Setor_BD>();
        }
    
        public int Codigo { get; set; }
        public string Nome { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Setor_BD> TB_CAD_SETOR { get; set; }
    }
}

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
    
    public partial class Setor_BD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Setor_BD()
        {
            this.TB_CAD_CHAVE = new HashSet<Chave_BD>();
            this.TB_CAD_FUNCIONARIO = new HashSet<Funcionario_BD>();
            this.TB_CAD_OPERADOR = new HashSet<Operador_BD>();
        }
    
        public short Codigo { get; set; }
        public int Tipo { get; set; }
        public string Nome { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chave_BD> TB_CAD_CHAVE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcionario_BD> TB_CAD_FUNCIONARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operador_BD> TB_CAD_OPERADOR { get; set; }
        public virtual Tipo_Setor_BD TB_CAD_TIPO_SETOR { get; set; }
    }
}
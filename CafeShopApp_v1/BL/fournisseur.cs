//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CafeShopApp_v1.BL
{
    using System;
    using System.Collections.Generic;
    
    public partial class fournisseur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fournisseur()
        {
            this.achats = new HashSet<achat>();
            this.reglements = new HashSet<reglement>();
        }
    
        public int id_fournisseur { get; set; }
        public string name_fournisseur { get; set; }
        public string adresse { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public Nullable<decimal> max_credit { get; set; }
        public Nullable<decimal> total_credit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<achat> achats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reglement> reglements { get; set; }
    }
}

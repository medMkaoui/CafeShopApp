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
    
    public partial class get_all_achats_Result
    {
        public int id_achat { get; set; }
        public Nullable<System.DateTime> date_achat { get; set; }
        public Nullable<int> fournisseur { get; set; }
        public Nullable<int> responsable_achat { get; set; }
        public Nullable<decimal> montant_total { get; set; }
        public Nullable<decimal> montant_rest { get; set; }
        public Nullable<bool> iscredit { get; set; }
    }
}
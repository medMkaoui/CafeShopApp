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
    
    public partial class get_all_charges_Result
    {
        public int id_charge { get; set; }
        public Nullable<System.DateTime> date_charge { get; set; }
        public Nullable<int> responsable_charge { get; set; }
        public Nullable<decimal> montant { get; set; }
        public string type_charge { get; set; }
        public string mode_reglement { get; set; }
        public string desc_charge { get; set; }
        public int id_user { get; set; }
        public string name_user { get; set; }
        public string adresse { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public string mot_passe { get; set; }
    }
}

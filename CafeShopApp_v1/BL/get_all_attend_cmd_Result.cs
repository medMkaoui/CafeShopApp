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
    
    public partial class get_all_attend_cmd_Result
    {
        public int id_cmd { get; set; }
        public string type_cmd { get; set; }
        public Nullable<System.DateTime> date_cmd { get; set; }
        public string t_able { get; set; }
        public Nullable<int> client { get; set; }
        public Nullable<int> responsable { get; set; }
        public Nullable<bool> enattend { get; set; }
        public string statu { get; set; }
        public Nullable<decimal> montant_total { get; set; }
        public Nullable<decimal> montant_rest { get; set; }
        public Nullable<bool> isready { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> modifiedd_at { get; set; }
        public Nullable<int> delivery_company { get; set; }
    }
}

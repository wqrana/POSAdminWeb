//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.edmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailCafeCategory
    {
        public long ClientID { get; set; }
        public long ORDID { get; set; }
        public Nullable<long> DISTID { get; set; }
        public Nullable<long> SCHID { get; set; }
        public long ItemMenuID { get; set; }
        public Nullable<long> MENUID { get; set; }
        public Nullable<long> CATID { get; set; }
        public Nullable<long> PREORDITEMID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime GDate { get; set; }
        public long CSTID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryType { get; set; }
        public Nullable<bool> canFree { get; set; }
        public Nullable<bool> canReduce { get; set; }
        public int QualifiedSort { get; set; }
        public string QualifiedDisplay { get; set; }
        public string AccountType { get; set; }
        public Nullable<double> NetPrice { get; set; }
        public Nullable<double> AccountTotal { get; set; }
        public Nullable<double> CashTotal { get; set; }
        public Nullable<double> PreorderTotal { get; set; }
        public Nullable<int> TotalCount { get; set; }
        public Nullable<int> AccountCount { get; set; }
        public Nullable<int> CashCount { get; set; }
        public Nullable<int> PreorderCount { get; set; }
        public Nullable<double> PaidPrice { get; set; }
    }
}

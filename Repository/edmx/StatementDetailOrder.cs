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
    
    public partial class StatementDetailOrder
    {
        public long ClientID { get; set; }
        public long CSTID { get; set; }
        public long SCHID { get; set; }
        public long ORDID { get; set; }
        public string OrderTypeName { get; set; }
        public int OrderType { get; set; }
        public Nullable<System.DateTime> GDate { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<int> TransType { get; set; }
        public string PaymentType { get; set; }
        public Nullable<double> TotalAccount { get; set; }
        public Nullable<double> TotalPaid { get; set; }
        public Nullable<double> SalesTax { get; set; }
        public Nullable<double> BalanceChange { get; set; }
        public int TotalItemQTY { get; set; }
    }
}

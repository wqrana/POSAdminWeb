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
    
    public partial class CustomerActivity
    {
        public long ClientID { get; set; }
        public long Id { get; set; }
        public Nullable<long> Customer_Pr_School_Id { get; set; }
        public long POS_Id { get; set; }
        public Nullable<long> School_Id { get; set; }
        public Nullable<long> Emp_Cashier_Id { get; set; }
        public long Customer_Id { get; set; }
        public Nullable<long> OrdersLog_Id { get; set; }
        public Nullable<System.DateTime> GDate { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime OrderDateLocal { get; set; }
        public Nullable<int> LunchType { get; set; }
        public Nullable<double> ADebit { get; set; }
        public Nullable<double> MDebit { get; set; }
        public Nullable<double> ACredit { get; set; }
        public Nullable<double> BCredit { get; set; }
        public Nullable<double> MCredit { get; set; }
        public Nullable<int> CheckNumber { get; set; }
        public Nullable<int> OverRide { get; set; }
        public Nullable<bool> isVoid { get; set; }
        public Nullable<int> TransType { get; set; }
        public Nullable<long> CreditAuth_Id { get; set; }
        public string CashierName { get; set; }
        public Nullable<double> Debit { get; set; }
        public Nullable<double> Credit { get; set; }
        public double Items { get; set; }
        public double SalesTax { get; set; }
        public int OrderType { get; set; }
    }
}

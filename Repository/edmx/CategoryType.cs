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
    
    public partial class CategoryType
    {
        public long ClientID { get; set; }
        public long ID { get; set; }
        public string Name { get; set; }
        public Nullable<bool> canFree { get; set; }
        public Nullable<bool> canReduce { get; set; }
        public bool isDeleted { get; set; }
        public Nullable<bool> isMealPlan { get; set; }
        public Nullable<bool> isMealEquiv { get; set; }
        public Nullable<System.DateTime> LastUpdatedUTC { get; set; }
        public Nullable<bool> UpdatedBySync { get; set; }
        public Nullable<int> Local_ID { get; set; }
        public bool CloudIDSync { get; set; }
    }
}

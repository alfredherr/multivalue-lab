//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_POCO
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER_MV
    {
        public int CUSTID { get; set; }
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        public Nullable<System.DateTime> SVC_PAID_DATE { get; set; }
        public Nullable<int> SVC_PRICE { get; set; }
        public Nullable<System.DateTime> SVC_END { get; set; }
        public Nullable<System.DateTime> SVC_START { get; set; }
        public Nullable<decimal> DISCOUNT { get; set; }
        public Nullable<int> PRICE { get; set; }
        public Nullable<int> LIST_PRICE { get; set; }
        public Nullable<System.DateTime> PAID_DATE { get; set; }
        public Nullable<System.DateTime> BUY_DATE { get; set; }
        public string SER_NUM { get; set; }
        public string DESCRIPTION { get; set; }
        public string PRODID { get; set; }
    }
}
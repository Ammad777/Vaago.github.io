//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vaago.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guest
    {
        public int id { get; set; }
        public string Members { get; set; }
        public string Adults { get; set; }
        public string Child { get; set; }
        public string phone { get; set; }
        public Nullable<int> Customer_ID { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}

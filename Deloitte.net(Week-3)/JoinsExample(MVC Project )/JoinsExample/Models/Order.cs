//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JoinsExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        public int Productid { get; set; }
        public int modelid { get; set; }
        public int Qty { get; set; }
        public string address { get; set; }
        public System.DateTime orderdate { get; set; }
    
        public virtual Model Model { get; set; }
        public virtual Product Product { get; set; }
    }
}

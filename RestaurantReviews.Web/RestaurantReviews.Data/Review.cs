//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantReviews.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class RestaurantReview
    {
        public int ID { get; set; }
        public Nullable<int> Review_ID { get; set; }
        public string Customer { get; set; }
        public Nullable<int> Rating { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
    }
}
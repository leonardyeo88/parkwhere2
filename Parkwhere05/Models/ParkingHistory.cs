//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parkwhere05.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParkingHistory
    {
        public int parkingHistoryId { get; set; }
        public Nullable<int> carparkId { get; set; }
        public string username { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
    }
}

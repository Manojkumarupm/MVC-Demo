//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tweeter.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class following
    {
        public int FId { get; set; }
        public string user_id { get; set; }
        public string following_id { get; set; }
    
        public virtual Person Person { get; set; }
    }
}

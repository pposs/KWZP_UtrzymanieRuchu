//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2019
{
    using System;
    using System.Collections.Generic;
    
    public partial class SafetyControl
    {
        public int IdInspection { get; set; }
        public string IdSafetyEmployee { get; set; }
        public int IdInspectedEmployee { get; set; }
        public System.DateTime SaftyControlDate { get; set; }
        public string SafetyControlDescription { get; set; }
        public string CompanyName { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}

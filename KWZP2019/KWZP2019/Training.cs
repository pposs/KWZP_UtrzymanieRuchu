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
    
    public partial class Training
    {
        public int IdTraining { get; set; }
        public Nullable<int> IdEmployee { get; set; }
        public string TrainingName { get; set; }
        public Nullable<System.DateTime> TrainingStartDate { get; set; }
        public Nullable<System.DateTime> TrainingEndDate { get; set; }
        public Nullable<decimal> TrainingPrice { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}

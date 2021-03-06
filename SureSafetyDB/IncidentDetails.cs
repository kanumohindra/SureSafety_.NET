//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SureSafetyDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class IncidentDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IncidentDetails()
        {
            this.EmployeeDetails = new HashSet<EmployeeDetails>();
        }
    
        public int Id { get; set; }
        public bool SuddenEvent { get; set; }
        public string SEDate { get; set; }
        public string SETime { get; set; }
        public bool GradualOT { get; set; }
        public string GDate { get; set; }
        public string GTime { get; set; }
        public string ReportedDate { get; set; }
        public string ReportedTime { get; set; }
        public string ReprotedTo { get; set; }
        public string LocationOfIncident { get; set; }
        public string Exposures { get; set; }
        public string IncidentDescription { get; set; }
        public string WhatHappened { get; set; }
        public string InjuryDescription { get; set; }
        public string ToolsUsed { get; set; }
        public string PersonalProtectiveEquipment { get; set; }
        public string Witness { get; set; }
        public bool FirstAidRequired { get; set; }
        public string FirstAidDate { get; set; }
        public string FirstAiderName { get; set; }
        public string FirstAiderPosition { get; set; }
        public bool AbsenceDueToIncident { get; set; }
        public string FirstDayOff { get; set; }
        public Nullable<bool> MedicalTreatmentRequired { get; set; }
        public Nullable<System.DateTime> MTDate { get; set; }
        public string FacilityType { get; set; }
        public string FacilityName_Address { get; set; }
        public string Practitioner { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeDetails> EmployeeDetails { get; set; }
    }
}

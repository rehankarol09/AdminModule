//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminModule.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class woman
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public woman()
        {
            this.enrollments = new HashSet<enrollment>();
            this.feedbacks = new HashSet<feedback>();
        }
    
        public int women_id { get; set; }
        public string women_full_name { get; set; }
        public string women_contact_number { get; set; }
        public string women_address { get; set; }
        public string women_city { get; set; }
        public string women_state { get; set; }
        public string women_fathername { get; set; }
        public string women_mothername { get; set; }
        public string women_spousename { get; set; }
        public string women_email { get; set; }
        public string women_password { get; set; }
        public string women_document { get; set; }
        public Nullable<bool> status { get; set; }
        public string women_marital_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<enrollment> enrollments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<feedback> feedbacks { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rating.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class reg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reg()
        {
            this.Logins = new HashSet<Login>();
        }
    
        public int UserId { get; set; }
        public string Name { get; set; }
        public System.DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Mobileno { get; set; }
        public string Emailid { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Login> Logins { get; set; }
    }
}

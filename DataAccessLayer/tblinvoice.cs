//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblinvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblinvoice()
        {
            this.tblcollections = new HashSet<tblcollection>();
        }
    
        public int id { get; set; }
        public Nullable<int> deliveryid { get; set; }
        public Nullable<decimal> totalamount { get; set; }
        public bool isactive { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> modifieddate { get; set; }
        public Nullable<int> modifiedby { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblcollection> tblcollections { get; set; }
        public virtual tblorderdelivery tblorderdelivery { get; set; }
    }
}

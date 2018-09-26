namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("pidevdb.libraryaddress")]
    public class libraryaddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public libraryaddress()
        {
            library = new HashSet<library>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string city { get; set; }

        public int code { get; set; }

        [StringLength(255)]
        public string country { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<library> library { get; set; }
    }
}

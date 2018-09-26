namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    [Table("pidevdb.library")]
    public class library
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public library()
        {
            librarydomains = new HashSet<librarydomains>();
        }

        public int libraryId { get; set; }

        [StringLength(255)]
        public string adressLib { get; set; }

        public double? altitude { get; set; }

        [StringLength(255)]
        public string dayclose { get; set; }

        [StringLength(255)]
        public string dayopening { get; set; }

        [StringLength(255)]
        public string libraryEmail { get; set; }

        public long? libraryPhoneNumer { get; set; }

        [StringLength(255)]
        public string librarySigle { get; set; }

        [StringLength(255)]
        public string libraryWebSite { get; set; }

        public double? longitude { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        public DateTime? timeClose { get; set; }

        public DateTime? timeOpening { get; set; }

        public int? address_id { get; set; }

        public int nbrePlaces { get; set; }

        public virtual libraryaddress libraryaddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<librarydomains> librarydomains { get; set; }
    }
}

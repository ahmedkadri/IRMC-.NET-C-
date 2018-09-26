namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public enum Offtype
    {
        Scholarship, Training, Employment
    }

    [Table("pidevdb.offre")]
    public  class offre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public offre()
        {
            user = new HashSet<user>();
        }

        [Key]
        public int idoffre { get; set; }

       // [Column(TypeName = "date")]
        public string creationdate { get; set; }

        [StringLength(255)]
        public string description { get; set; }

      //  [Column(TypeName = "date")]
        public string experationdate { get; set; }

        public Offtype offretype { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public int? quiz2_quiz_id { get; set; }

        public virtual quiz quiz2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> user { get; set; }
    }
}

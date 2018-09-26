namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("pidevdb.user")]
    public  class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            _event = new HashSet<_event>();
            reservation = new HashSet<reservation>();
            signaluser = new HashSet<signaluser>();
            signaluser1 = new HashSet<signaluser>();
            offre = new HashSet<offre>();
        }

        [Key]
        public long idUser { get; set; }

        [StringLength(255)]
        public string actionToken { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateinsription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datenaissance { get; set; }

        [StringLength(255)]
        public string etat { get; set; }

        [StringLength(255)]
        public string first_name { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        [StringLength(255)]
        public string last_name { get; set; }

        [StringLength(255)]
        public string mail { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string phone_number { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        public int? CV_id_CV { get; set; }

        public virtual curriculumvitae curriculumvitae { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<_event> _event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<signaluser> signaluser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<signaluser> signaluser1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<offre> offre { get; set; }
    }
}

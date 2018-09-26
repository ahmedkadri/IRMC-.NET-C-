namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("pidevdb.curriculumvitae")]
    public  class curriculumvitae
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public curriculumvitae()
        {
            user = new HashSet<user>();
            formation = new HashSet<formation>();
            experiencepro = new HashSet<experiencepro>();
            diplome = new HashSet<diplome>();
        }

        [Key]
        public int id_CV { get; set; }

        [StringLength(255)]
        public string adresse { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datenaissance { get; set; }

        [StringLength(255)]
        public string imageCV { get; set; }

        [StringLength(255)]
        public string interet { get; set; }

        [StringLength(255)]
        public string langue { get; set; }

        [StringLength(255)]
        public string mail { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string phone { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formation> formation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<experiencepro> experiencepro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diplome> diplome { get; set; }
    }
}

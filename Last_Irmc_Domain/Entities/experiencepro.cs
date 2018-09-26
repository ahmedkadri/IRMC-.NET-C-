namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("pidevdb.experiencepro")]
    public  class experiencepro
    {
        [Key]
        public int IDExp { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_exp { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string intituleExp { get; set; }

        [StringLength(255)]
        public string lieuStage { get; set; }

        public int? CVExp_id_CV { get; set; }

        public virtual curriculumvitae curriculumvitae { get; set; }
    }
}

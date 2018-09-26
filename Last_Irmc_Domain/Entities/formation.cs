namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("pidevdb.formation")]
    public class formation
    {
        [Key]
        public int idFormation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateFormation { get; set; }

        [StringLength(255)]
        public string ecole { get; set; }

        [StringLength(255)]
        public string intitule { get; set; }

        public int? CVF_id_CV { get; set; }

        public virtual curriculumvitae curriculumvitae { get; set; }
    }
}

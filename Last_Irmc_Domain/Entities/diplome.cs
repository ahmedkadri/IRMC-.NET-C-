namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("pidevdb.diplome")]
    public class diplome
    {
        [Key]
        public int idDip { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateDip { get; set; }

        [StringLength(255)]
        public string ecoleDip { get; set; }

        [StringLength(255)]
        public string intituleDip { get; set; }

        [StringLength(255)]
        public string mentionDip { get; set; }

        public int? CVDip_id_CV { get; set; }

        public virtual curriculumvitae curriculumvitae { get; set; }
    }
}

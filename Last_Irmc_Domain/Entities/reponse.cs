namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("pidevdb.reponse")]
    public  class reponse
    {
        [Key]
        public int reponse_id { get; set; }

        [Column(TypeName = "bit")]
        public bool correcte { get; set; }

        [Column(TypeName = "bit")]
        public bool repcheck { get; set; }

        [StringLength(255)]
        public string lareponse { get; set; }

        public int? questionx_question_id { get; set; }

        public virtual question question { get; set; }
    }
}

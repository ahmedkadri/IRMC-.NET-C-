namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    [Table("pidevdb.mon_video")]
    public  class mon_video
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idVideo { get; set; }

        [StringLength(255)]
        public string URI { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public DateTime? uploadDate { get; set; }

        public int vues { get; set; }
    }
}

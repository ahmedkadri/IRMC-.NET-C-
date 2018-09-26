namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("pidevdb.document")]
    public class document
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string category { get; set; }

        public DateTime? localdtae { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string path { get; set; }
    }
}

namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("pidevdb.signaluser")]
    public  class signaluser
    {
        public int id { get; set; }

        [StringLength(255)]
        public string otherContent { get; set; }

        public DateTime? signalDate { get; set; }

        public long? doer_idUser { get; set; }

        public long? signaled_idUser { get; set; }

        public virtual user user { get; set; }

        public virtual user user1 { get; set; }
    }
}

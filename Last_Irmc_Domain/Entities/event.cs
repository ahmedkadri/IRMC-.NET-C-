namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("pidevdb.event")]
    public class _event
    {
        [Key]
        public int idEvent { get; set; }

        [Column(TypeName = "bit")]
        public bool canceled { get; set; }

        public int capacity { get; set; }

        [StringLength(255)]
        public string categoryEvent { get; set; }

        [StringLength(255)]
        public string contactInfo { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "date")]
        public DateTime? endDate { get; set; }

        [StringLength(255)]
        public string imageEvent { get; set; }

        [StringLength(255)]
        public string location { get; set; }

        public int nbPart { get; set; }

        [Column(TypeName = "bit")]
        public bool notRegistered { get; set; }

        [Column(TypeName = "bit")]
        public bool registered { get; set; }

        [Column(TypeName = "date")]
        public DateTime? startDate { get; set; }

        [StringLength(255)]
        public string subtitle { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [Column(TypeName = "bit")]
        public bool valide { get; set; }

        public long? user_idUser { get; set; }

        public virtual user user { get; set; }
    }
}

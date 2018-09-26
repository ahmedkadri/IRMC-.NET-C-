namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    [Table("pidevdb.reservation")]
    public  class reservation
    {
        public int reservationId { get; set; }

        public long? owner_idUser { get; set; }

        public string quitTime { get; set; }

        [DataType(DataType.Date)]
        public string reservationDate { get; set; }

        public string reservationTime { get; set; }

        public string arrivalTime { get; set; }

        public virtual user user { get; set; }
    }
}

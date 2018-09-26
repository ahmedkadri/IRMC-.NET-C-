using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAST_IRMC_WEB.Models
{
    public class ReservationViewModel
    {
        [DataType(DataType.Date)]
        public string ReservationDate { get; set; }
    }
}
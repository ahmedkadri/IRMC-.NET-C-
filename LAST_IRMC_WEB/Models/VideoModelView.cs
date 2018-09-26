using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAST_IRMC_WEB.Models
{
    public class VideoModelView
    {
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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAST_IRMC_WEB.Models
{
    public class LibraryViewModel
    {

        public int libraryId { get; set; }

        [StringLength(255)]
        public string adressLib { get; set; }

        public double? altitude { get; set; }

        [StringLength(255)]
        public string dayclose { get; set; }

        [StringLength(255)]
        public string dayopening { get; set; }

        [StringLength(255)]
        public string libraryEmail { get; set; }

        public long? libraryPhoneNumer { get; set; }

        [StringLength(255)]
        public string librarySigle { get; set; }

        [StringLength(255)]
        public string libraryWebSite { get; set; }

        public double? longitude { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        public DateTime? timeClose { get; set; }

        public DateTime? timeOpening { get; set; }

        public int? address_id { get; set; }

        public int nbrePlaces { get; set; }


    }
}

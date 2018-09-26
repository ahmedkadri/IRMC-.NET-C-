using Last_Irmc_Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LAST_IRMC_WEB.Models
{
    public enum Offtype
    {
        Scholarship, Training, Employment
    }
    public class OffreModelView
    {
        public int idoffre { get; set; }

        [DataType(DataType.Date)]
        public DateTime? creationdate { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? experationdate { get; set; }

        public Offtype oftype { get; set; }

        [Required(ErrorMessage ="le champ est obligatoire")]
        [StringLength(255)]
        public string title { get; set; }
        

        public virtual quiz quiz { get; set; }


    }
}
namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   
    public enum quizztype
    {
        PSYCHO_TECHNIQUE, TECHNIQUE, QI
    }

    [Table("pidevdb.quiz")]
    public  class quiz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public quiz()
        {
            offre = new HashSet<offre>();
            liste_question = new HashSet<question>();
        }

        [Key]
        public int quiz_id { get; set; }

        [StringLength(255)]
        public string quiz_nom { get; set; }

        public quizztype quiztype { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<offre> offre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<question> liste_question { get; set; }
    }
}

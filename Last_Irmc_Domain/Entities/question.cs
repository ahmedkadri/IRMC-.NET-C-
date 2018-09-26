namespace Last_Irmc_Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    [Table("pidevdb.question")]
    public  class question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public question()
        {
            reponse = new HashSet<reponse>();
        }

        [Key]
        public int question_id { get; set; }

        [StringLength(255)]
        public string question_actual { get; set; }

        public int quiz3_quiz_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reponse> reponse { get; set; }

        public virtual quiz quiz { get; set; }
    }
}

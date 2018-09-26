namespace Last_Irmc_DATA
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Last_Irmc_Domain;

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class IrmcContext : DbContext
    {
        public IrmcContext()
            : base("name=IrmcContext")
        {
        }

        public virtual DbSet<curriculumvitae> curriculumvitae { get; set; }
        public virtual DbSet<diplome> diplome { get; set; }
        public virtual DbSet<document> document { get; set; }
        public virtual DbSet<_event> _event { get; set; }
        public virtual DbSet<experiencepro> experiencepro { get; set; }
        public virtual DbSet<formation> formation { get; set; }
        public virtual DbSet<image> image { get; set; }
        public virtual DbSet<library> library { get; set; }
        public virtual DbSet<libraryaddress> libraryaddress { get; set; }
        public virtual DbSet<librarydomains> librarydomains { get; set; }
        public virtual DbSet<mon_video> mon_video { get; set; }
        public virtual DbSet<offre> offre { get; set; }
        public virtual DbSet<question> question { get; set; }
        public virtual DbSet<quiz> quiz { get; set; }
        public virtual DbSet<reponse> reponse { get; set; }
        public virtual DbSet<reservation> reservation { get; set; }
        public virtual DbSet<signaluser> signaluser { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.imageCV)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.interet)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.langue)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .HasMany(e => e.user)
                .WithOptional(e => e.curriculumvitae)
                .HasForeignKey(e => e.CV_id_CV);

            modelBuilder.Entity<curriculumvitae>()
                .HasMany(e => e.formation)
                .WithOptional(e => e.curriculumvitae)
                .HasForeignKey(e => e.CVF_id_CV);

            modelBuilder.Entity<curriculumvitae>()
                .HasMany(e => e.experiencepro)
                .WithOptional(e => e.curriculumvitae)
                .HasForeignKey(e => e.CVExp_id_CV);

            modelBuilder.Entity<curriculumvitae>()
                .HasMany(e => e.diplome)
                .WithOptional(e => e.curriculumvitae)
                .HasForeignKey(e => e.CVDip_id_CV);

            modelBuilder.Entity<diplome>()
                .Property(e => e.ecoleDip)
                .IsUnicode(false);

            modelBuilder.Entity<diplome>()
                .Property(e => e.intituleDip)
                .IsUnicode(false);

            modelBuilder.Entity<diplome>()
                .Property(e => e.mentionDip)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<_event>()
                .Property(e => e.categoryEvent)
                .IsUnicode(false);

            modelBuilder.Entity<_event>()
                .Property(e => e.contactInfo)
                .IsUnicode(false);

            modelBuilder.Entity<_event>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<_event>()
                .Property(e => e.imageEvent)
                .IsUnicode(false);

            modelBuilder.Entity<_event>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<_event>()
                .Property(e => e.subtitle)
                .IsUnicode(false);

            modelBuilder.Entity<_event>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<experiencepro>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<experiencepro>()
                .Property(e => e.intituleExp)
                .IsUnicode(false);

            modelBuilder.Entity<experiencepro>()
                .Property(e => e.lieuStage)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.ecole)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.intitule)
                .IsUnicode(false);

            modelBuilder.Entity<image>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<library>()
                .Property(e => e.adressLib)
                .IsUnicode(false);

            modelBuilder.Entity<library>()
                .Property(e => e.dayclose)
                .IsUnicode(false);

            modelBuilder.Entity<library>()
                .Property(e => e.dayopening)
                .IsUnicode(false);

            modelBuilder.Entity<library>()
                .Property(e => e.libraryEmail)
                .IsUnicode(false);

            modelBuilder.Entity<library>()
                .Property(e => e.librarySigle)
                .IsUnicode(false);

            modelBuilder.Entity<library>()
                .Property(e => e.libraryWebSite)
                .IsUnicode(false);

            modelBuilder.Entity<library>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<libraryaddress>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<libraryaddress>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<libraryaddress>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<libraryaddress>()
                .HasMany(e => e.library)
                .WithOptional(e => e.libraryaddress)
                .HasForeignKey(e => e.address_id);

            modelBuilder.Entity<librarydomains>()
                .Property(e => e.domainName)
                .IsUnicode(false);

            modelBuilder.Entity<librarydomains>()
                .HasMany(e => e.library)
                .WithMany(e => e.librarydomains)
                .Map(m => m.ToTable("library_librarydomains").MapLeftKey("domains_id").MapRightKey("Library_libraryId"));

            modelBuilder.Entity<mon_video>()
                .Property(e => e.URI)
                .IsUnicode(false);

            modelBuilder.Entity<mon_video>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<mon_video>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<offre>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<offre>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.question_actual)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .HasMany(e => e.reponse)
                .WithOptional(e => e.question)
                .HasForeignKey(e => e.questionx_question_id);

            modelBuilder.Entity<quiz>()
                .Property(e => e.quiz_nom)
                .IsUnicode(false);

            modelBuilder.Entity<quiz>()
                .HasMany(e => e.offre)
                .WithOptional(e => e.quiz2)
                .HasForeignKey(e => e.quiz2_quiz_id);

            modelBuilder.Entity<quiz>()
                .HasMany(e => e.liste_question)
                .WithRequired(e => e.quiz)
                .HasForeignKey(e => e.quiz3_quiz_id);

          






            modelBuilder.Entity<reponse>()
                .Property(e => e.lareponse)
                .IsUnicode(false);

            modelBuilder.Entity<signaluser>()
                .Property(e => e.otherContent)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.actionToken)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.etat)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e._event)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_idUser);

            modelBuilder.Entity<user>()
                .HasMany(e => e.reservation)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.owner_idUser);

            modelBuilder.Entity<user>()
                .HasMany(e => e.signaluser)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.doer_idUser);

            modelBuilder.Entity<user>()
                .HasMany(e => e.signaluser1)
                .WithOptional(e => e.user1)
                .HasForeignKey(e => e.signaled_idUser);

            modelBuilder.Entity<user>()
                .HasMany(e => e.offre)
                .WithMany(e => e.user)
                .Map(m => m.ToTable("offre_user").MapLeftKey("listusr_idUser").MapRightKey("Offre_idoffre"));
        }
    }
}

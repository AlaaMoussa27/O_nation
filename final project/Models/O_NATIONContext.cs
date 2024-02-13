using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace final_project.Models
{
    public partial class O_NATIONContext : DbContext
    {
        private const string ConnectionString = "Data Source=DESKTOP-5FI2MCA;Initial Catalog=O_NATION;Integrated Security=True";
        public O_NATIONContext()
        {
        }

        public O_NATIONContext(DbContextOptions<O_NATIONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CountryGroup> CountryGroups { get; set; }
        public virtual DbSet<CountryImage> CountryImages { get; set; }
        public virtual DbSet<CountryPurposePaper> CountryPurposePapers { get; set; }
        public virtual DbSet<Embassy> Embassies { get; set; }
        public virtual DbSet<Paper> Papers { get; set; }
        public virtual DbSet<Purpose> Purposes { get; set; }
        public virtual DbSet<TouristicPlace> TouristicPlaces { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserEmail> UserEmails { get; set; }
        public virtual DbSet<UserPaper> UserPapers { get; set; }
        public virtual DbSet<UserPhone> UserPhones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5FI2MCA;Initial Catalog=O_NATION;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("COUNTRY");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.CountryContinent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Country_Continent");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Country_Name");

                entity.Property(e => e.CountryNotes)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("Country_Notes");
            });

            modelBuilder.Entity<CountryGroup>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.CountryGroup1 })
                    .HasName("PK__COUNTRY___B597CE1D98FD4CF2");

                entity.ToTable("COUNTRY_GROUP");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.CountryGroup1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Country_Group");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryGroups)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COUNTRY_G__Count__398D8EEE");
            });

            modelBuilder.Entity<CountryImage>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.ImageId })
                    .HasName("PK__COUNTRY___03FC7F9DFA5FF4B5");

                entity.ToTable("COUNTRY_IMAGES");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.ImageId).HasColumnName("Image_ID");

                entity.Property(e => e.ImageData)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Image_Data");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryImages)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COUNTRY_I__Count__3C69FB99");
            });

            modelBuilder.Entity<CountryPurposePaper>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.PaperId, e.PurposeId })
                    .HasName("PK__COUNTRY___53CACEC2C1B15C81");

                entity.ToTable("COUNTRY_PURPOSE_PAPER");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.PaperId).HasColumnName("Paper_ID");

                entity.Property(e => e.PurposeId).HasColumnName("Purpose_ID");

                entity.Property(e => e.Details)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryPurposePapers)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COUNTRY_P__Count__5535A963");

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.CountryPurposePapers)
                    .HasForeignKey(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COUNTRY_P__Paper__534D60F1");

                entity.HasOne(d => d.Purpose)
                    .WithMany(p => p.CountryPurposePapers)
                    .HasForeignKey(d => d.PurposeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COUNTRY_P__Purpo__5441852A");
            });

            modelBuilder.Entity<Embassy>(entity =>
            {
                entity.HasKey(e => e.EmbassiesId)
                    .HasName("PK__EMBASSIE__54B2753CBEAFBDAC");

                entity.ToTable("EMBASSIES");

                entity.Property(e => e.EmbassiesId).HasColumnName("Embassies_ID");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.EmbassiesFax)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Embassies_Fax");

                entity.Property(e => e.EmbassiesLocation)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Embassies_Location");

                entity.Property(e => e.EmbassiesMail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Embassies_Mail");

                entity.Property(e => e.EmbassiesName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Embassies_Name");

                entity.Property(e => e.EmbassiesPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Embassies_Phone");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Embassies)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__EMBASSIES__Count__5812160E");
            });

            modelBuilder.Entity<Paper>(entity =>
            {
                entity.ToTable("PAPER");

                entity.Property(e => e.PaperId).HasColumnName("Paper_ID");

                entity.Property(e => e.PaperName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Paper_Name");

                entity.Property(e => e.PaperPlace)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Paper_Place");
            });

            modelBuilder.Entity<Purpose>(entity =>
            {
                entity.ToTable("PURPOSE");

                entity.Property(e => e.PurposeId).HasColumnName("Purpose_ID");

                entity.Property(e => e.PurposeName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Purpose_Name");

                entity.Property(e => e.PurposeType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Purpose_Type");
            });

            modelBuilder.Entity<TouristicPlace>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.PlaceName })
                    .HasName("PK__TOURISTI__AD46DB979129963D");

                entity.ToTable("TOURISTIC_PLACES");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.PlaceName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Place_Name");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TouristicPlaces)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOURISTIC__Count__3F466844");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("_USER");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.PurposeId).HasColumnName("Purpose_ID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("User_Name");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("User_Password");

                entity.Property(e => e.UserPhoto)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("User_Photo");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK___USER__Country_I__440B1D61");

                entity.HasOne(d => d.Purpose)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PurposeId)
                    .HasConstraintName("FK___USER__Purpose_I__44FF419A");
            });

            modelBuilder.Entity<UserEmail>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Email })
                    .HasName("PK__USER_EMA__6AF081C3299FC144");

                entity.ToTable("USER_EMAIL");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserEmails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_EMAI__User___4CA06362");
            });

            modelBuilder.Entity<UserPaper>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PaperId })
                    .HasName("PK__USER_PAP__5E664E502AF73A2F");

                entity.ToTable("USER_PAPER");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.PaperId).HasColumnName("Paper_ID");

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.UserPapers)
                    .HasForeignKey(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_PAPE__Paper__5070F446");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPapers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_PAPE__User___4F7CD00D");
            });

            modelBuilder.Entity<UserPhone>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PhoneNum })
                    .HasName("PK__USER_PHO__8731B6833F2FD4BA");

                entity.ToTable("USER_PHONE");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.PhoneNum)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Phone_Num");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPhones)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER_PHON__User___49C3F6B7");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

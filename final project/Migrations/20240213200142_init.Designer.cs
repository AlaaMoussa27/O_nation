﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using final_project.Models;

namespace final_project.Migrations
{
    [DbContext(typeof(O_NATIONContext))]
    [Migration("20240213200142_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("final_project.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Country_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryContinent")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Country_Continent");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Country_Name");

                    b.Property<string>("CountryNotes")
                        .HasMaxLength(8000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8000)")
                        .HasColumnName("Country_Notes");

                    b.HasKey("CountryId");

                    b.ToTable("COUNTRY");
                });

            modelBuilder.Entity("final_project.Models.CountryGroup", b =>
                {
                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("Country_ID");

                    b.Property<string>("CountryGroup1")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Country_Group");

                    b.HasKey("CountryId", "CountryGroup1")
                        .HasName("PK__COUNTRY___B597CE1D98FD4CF2");

                    b.ToTable("COUNTRY_GROUP");
                });

            modelBuilder.Entity("final_project.Models.CountryImage", b =>
                {
                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("Country_ID");

                    b.Property<int>("ImageId")
                        .HasColumnType("int")
                        .HasColumnName("Image_ID");

                    b.Property<string>("ImageData")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Image_Data");

                    b.HasKey("CountryId", "ImageId")
                        .HasName("PK__COUNTRY___03FC7F9DFA5FF4B5");

                    b.ToTable("COUNTRY_IMAGES");
                });

            modelBuilder.Entity("final_project.Models.CountryPurposePaper", b =>
                {
                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("Country_ID");

                    b.Property<int>("PaperId")
                        .HasColumnType("int")
                        .HasColumnName("Paper_ID");

                    b.Property<int>("PurposeId")
                        .HasColumnType("int")
                        .HasColumnName("Purpose_ID");

                    b.Property<string>("Details")
                        .HasMaxLength(8000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8000)");

                    b.HasKey("CountryId", "PaperId", "PurposeId")
                        .HasName("PK__COUNTRY___53CACEC2C1B15C81");

                    b.HasIndex("PaperId");

                    b.HasIndex("PurposeId");

                    b.ToTable("COUNTRY_PURPOSE_PAPER");
                });

            modelBuilder.Entity("final_project.Models.Embassy", b =>
                {
                    b.Property<int>("EmbassiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Embassies_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("Country_ID");

                    b.Property<string>("EmbassiesFax")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Embassies_Fax");

                    b.Property<string>("EmbassiesLocation")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Embassies_Location");

                    b.Property<string>("EmbassiesMail")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Embassies_Mail");

                    b.Property<string>("EmbassiesName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Embassies_Name");

                    b.Property<string>("EmbassiesPhone")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Embassies_Phone");

                    b.HasKey("EmbassiesId")
                        .HasName("PK__EMBASSIE__54B2753CBEAFBDAC");

                    b.HasIndex("CountryId");

                    b.ToTable("EMBASSIES");
                });

            modelBuilder.Entity("final_project.Models.Paper", b =>
                {
                    b.Property<int>("PaperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Paper_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PaperName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Paper_Name");

                    b.Property<string>("PaperPlace")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Paper_Place");

                    b.HasKey("PaperId");

                    b.ToTable("PAPER");
                });

            modelBuilder.Entity("final_project.Models.Purpose", b =>
                {
                    b.Property<int>("PurposeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Purpose_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PurposeName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Purpose_Name");

                    b.Property<string>("PurposeType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Purpose_Type");

                    b.HasKey("PurposeId");

                    b.ToTable("PURPOSE");
                });

            modelBuilder.Entity("final_project.Models.TouristicPlace", b =>
                {
                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("Country_ID");

                    b.Property<string>("PlaceName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Place_Name");

                    b.HasKey("CountryId", "PlaceName")
                        .HasName("PK__TOURISTI__AD46DB979129963D");

                    b.ToTable("TOURISTIC_PLACES");
                });

            modelBuilder.Entity("final_project.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("User_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("Country_ID");

                    b.Property<int?>("PurposeId")
                        .HasColumnType("int")
                        .HasColumnName("Purpose_ID");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("User_Name");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("User_Password");

                    b.Property<string>("UserPhoto")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("User_Photo");

                    b.HasKey("UserId");

                    b.HasIndex("CountryId");

                    b.HasIndex("PurposeId");

                    b.ToTable("_USER");
                });

            modelBuilder.Entity("final_project.Models.UserEmail", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_ID");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "Email")
                        .HasName("PK__USER_EMA__6AF081C3299FC144");

                    b.ToTable("USER_EMAIL");
                });

            modelBuilder.Entity("final_project.Models.UserPaper", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_ID");

                    b.Property<int>("PaperId")
                        .HasColumnType("int")
                        .HasColumnName("Paper_ID");

                    b.HasKey("UserId", "PaperId")
                        .HasName("PK__USER_PAP__5E664E502AF73A2F");

                    b.HasIndex("PaperId");

                    b.ToTable("USER_PAPER");
                });

            modelBuilder.Entity("final_project.Models.UserPhone", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_ID");

                    b.Property<string>("PhoneNum")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Phone_Num");

                    b.HasKey("UserId", "PhoneNum")
                        .HasName("PK__USER_PHO__8731B6833F2FD4BA");

                    b.ToTable("USER_PHONE");
                });

            modelBuilder.Entity("final_project.Models.CountryGroup", b =>
                {
                    b.HasOne("final_project.Models.Country", "Country")
                        .WithMany("CountryGroups")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK__COUNTRY_G__Count__398D8EEE")
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("final_project.Models.CountryImage", b =>
                {
                    b.HasOne("final_project.Models.Country", "Country")
                        .WithMany("CountryImages")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK__COUNTRY_I__Count__3C69FB99")
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("final_project.Models.CountryPurposePaper", b =>
                {
                    b.HasOne("final_project.Models.Country", "Country")
                        .WithMany("CountryPurposePapers")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK__COUNTRY_P__Count__5535A963")
                        .IsRequired();

                    b.HasOne("final_project.Models.Paper", "Paper")
                        .WithMany("CountryPurposePapers")
                        .HasForeignKey("PaperId")
                        .HasConstraintName("FK__COUNTRY_P__Paper__534D60F1")
                        .IsRequired();

                    b.HasOne("final_project.Models.Purpose", "Purpose")
                        .WithMany("CountryPurposePapers")
                        .HasForeignKey("PurposeId")
                        .HasConstraintName("FK__COUNTRY_P__Purpo__5441852A")
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Paper");

                    b.Navigation("Purpose");
                });

            modelBuilder.Entity("final_project.Models.Embassy", b =>
                {
                    b.HasOne("final_project.Models.Country", "Country")
                        .WithMany("Embassies")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK__EMBASSIES__Count__5812160E");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("final_project.Models.TouristicPlace", b =>
                {
                    b.HasOne("final_project.Models.Country", "Country")
                        .WithMany("TouristicPlaces")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK__TOURISTIC__Count__3F466844")
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("final_project.Models.User", b =>
                {
                    b.HasOne("final_project.Models.Country", "Country")
                        .WithMany("Users")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK___USER__Country_I__440B1D61");

                    b.HasOne("final_project.Models.Purpose", "Purpose")
                        .WithMany("Users")
                        .HasForeignKey("PurposeId")
                        .HasConstraintName("FK___USER__Purpose_I__44FF419A");

                    b.Navigation("Country");

                    b.Navigation("Purpose");
                });

            modelBuilder.Entity("final_project.Models.UserEmail", b =>
                {
                    b.HasOne("final_project.Models.User", "User")
                        .WithMany("UserEmails")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__USER_EMAI__User___4CA06362")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("final_project.Models.UserPaper", b =>
                {
                    b.HasOne("final_project.Models.Paper", "Paper")
                        .WithMany("UserPapers")
                        .HasForeignKey("PaperId")
                        .HasConstraintName("FK__USER_PAPE__Paper__5070F446")
                        .IsRequired();

                    b.HasOne("final_project.Models.User", "User")
                        .WithMany("UserPapers")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__USER_PAPE__User___4F7CD00D")
                        .IsRequired();

                    b.Navigation("Paper");

                    b.Navigation("User");
                });

            modelBuilder.Entity("final_project.Models.UserPhone", b =>
                {
                    b.HasOne("final_project.Models.User", "User")
                        .WithMany("UserPhones")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__USER_PHON__User___49C3F6B7")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("final_project.Models.Country", b =>
                {
                    b.Navigation("CountryGroups");

                    b.Navigation("CountryImages");

                    b.Navigation("CountryPurposePapers");

                    b.Navigation("Embassies");

                    b.Navigation("TouristicPlaces");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("final_project.Models.Paper", b =>
                {
                    b.Navigation("CountryPurposePapers");

                    b.Navigation("UserPapers");
                });

            modelBuilder.Entity("final_project.Models.Purpose", b =>
                {
                    b.Navigation("CountryPurposePapers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("final_project.Models.User", b =>
                {
                    b.Navigation("UserEmails");

                    b.Navigation("UserPapers");

                    b.Navigation("UserPhones");
                });
#pragma warning restore 612, 618
        }
    }
}
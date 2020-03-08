﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eVotingSystem.DAL.EF;

namespace eVotingSystem.WebAPI.Migrations
{
    [DbContext(typeof(eVotingSystemDbContext))]
    [Migration("20200302214853_testtt")]
    partial class testtt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eVotingSystem.CORE.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalityId")
                        .HasColumnType("int");

                    b.Property<int>("Ordinal")
                        .HasColumnType("int");

                    b.Property<int?>("PictureId")
                        .HasColumnType("int");

                    b.Property<int?>("PoliticalOrganizationId")
                        .HasColumnType("int");

                    b.Property<int?>("ResumeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("PictureId");

                    b.HasIndex("PoliticalOrganizationId");

                    b.HasIndex("ResumeId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectionCycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ElectionCycles");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectionCycleElectiveList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ElectionCycleId")
                        .HasColumnType("int");

                    b.Property<int>("ElectiveListId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ElectionCycleId");

                    b.HasIndex("ElectiveListId");

                    b.ToTable("ElectionCycleElectiveLists");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectionOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("ElectionOptionType")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("PoliticalOrganizationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("PoliticalOrganizationId");

                    b.ToTable("ElectionOptions");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectionRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuperiorElectionRegionId")
                        .HasColumnType("int");

                    b.Property<int?>("SuperiorRegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuperiorElectionRegionId");

                    b.ToTable("ElectionRegions");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectionUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ElectionRegionId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VotingBegginingTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VotingEndTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ElectionRegionId");

                    b.ToTable("ElectionUnits");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectiveList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ElectionPositionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ElectionRegionId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ElectionRegionId");

                    b.ToTable("ElectiveLists");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectiveListElectionOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ElectionOptionId")
                        .HasColumnType("int");

                    b.Property<int>("ElectiveListId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ElectionOptionId");

                    b.HasIndex("ElectiveListId");

                    b.ToTable("ElectiveListElectionOptions");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("PictureId")
                        .HasColumnType("int");

                    b.Property<int?>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("RecieverId")
                        .HasColumnType("int");

                    b.Property<int?>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfSending")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PictureId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.PoliticalOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FileId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ordinal")
                        .HasColumnType("int");

                    b.Property<int?>("PictureId")
                        .HasColumnType("int");

                    b.Property<int>("PoliticalOrientation")
                        .HasColumnType("int");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("FileId");

                    b.HasIndex("PictureId");

                    b.ToTable("PoliticalOrganizations");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("ElectionUnitId")
                        .HasColumnType("int");

                    b.Property<int?>("FileId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserTypes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("ElectionUnitId");

                    b.HasIndex("FileId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ElectionOptionId")
                        .HasColumnType("int");

                    b.Property<int?>("ElectionUnitId")
                        .HasColumnType("int");

                    b.Property<int>("ElectiveListId")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<int>("SchoolingDegreeLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfVoting")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Token")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("VoterCityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ElectionOptionId");

                    b.HasIndex("ElectionUnitId");

                    b.HasIndex("ElectiveListId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("VoterCityId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.Voter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVoted")
                        .HasColumnType("bit");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.Property<int>("SchoolingDegreeLevel")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NationalityId");

                    b.HasIndex("UserId");

                    b.ToTable("Voters");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.Candidate", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("eVotingSystem.CORE.Models.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("eVotingSystem.CORE.Models.File", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId");

                    b.HasOne("eVotingSystem.CORE.Models.PoliticalOrganization", "PoliticalOrganization")
                        .WithMany()
                        .HasForeignKey("PoliticalOrganizationId");

                    b.HasOne("eVotingSystem.CORE.Models.File", "Resume")
                        .WithMany()
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.City", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectionCycleElectiveList", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.ElectionCycle", "ElectionCycle")
                        .WithMany()
                        .HasForeignKey("ElectionCycleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("eVotingSystem.CORE.Models.ElectiveList", "ElectiveList")
                        .WithMany()
                        .HasForeignKey("ElectiveListId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectionOption", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateId");

                    b.HasOne("eVotingSystem.CORE.Models.PoliticalOrganization", "PoliticalOrganization")
                        .WithMany()
                        .HasForeignKey("PoliticalOrganizationId");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectionRegion", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.ElectionRegion", "SuperiorElectionRegion")
                        .WithMany()
                        .HasForeignKey("SuperiorElectionRegionId");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectionUnit", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.ElectionRegion", "ElectionRegion")
                        .WithMany()
                        .HasForeignKey("ElectionRegionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectiveList", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.ElectionRegion", "ElectionRegion")
                        .WithMany()
                        .HasForeignKey("ElectionRegionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.ElectiveListElectionOption", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.ElectionOption", "ElectionOption")
                        .WithMany()
                        .HasForeignKey("ElectionOptionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("eVotingSystem.CORE.Models.ElectiveList", "ElectiveList")
                        .WithMany()
                        .HasForeignKey("ElectiveListId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.Message", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.File", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId");

                    b.HasOne("eVotingSystem.CORE.Models.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId");

                    b.HasOne("eVotingSystem.CORE.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.PoliticalOrganization", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("eVotingSystem.CORE.Models.File", "File")
                        .WithMany()
                        .HasForeignKey("FileId");

                    b.HasOne("eVotingSystem.CORE.Models.File", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.User", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("eVotingSystem.CORE.Models.ElectionUnit", "ElectionUnit")
                        .WithMany()
                        .HasForeignKey("ElectionUnitId");

                    b.HasOne("eVotingSystem.CORE.Models.File", "File")
                        .WithMany()
                        .HasForeignKey("FileId");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.Vote", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.ElectionOption", "ElectionOption")
                        .WithMany()
                        .HasForeignKey("ElectionOptionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("eVotingSystem.CORE.Models.ElectionUnit", "ElectionUnit")
                        .WithMany()
                        .HasForeignKey("ElectionUnitId");

                    b.HasOne("eVotingSystem.CORE.Models.ElectiveList", "ElectiveList")
                        .WithMany()
                        .HasForeignKey("ElectiveListId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("eVotingSystem.CORE.Models.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");

                    b.HasOne("eVotingSystem.CORE.Models.City", "VoterCity")
                        .WithMany()
                        .HasForeignKey("VoterCityId");
                });

            modelBuilder.Entity("eVotingSystem.CORE.Models.Voter", b =>
                {
                    b.HasOne("eVotingSystem.CORE.Models.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");

                    b.HasOne("eVotingSystem.CORE.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

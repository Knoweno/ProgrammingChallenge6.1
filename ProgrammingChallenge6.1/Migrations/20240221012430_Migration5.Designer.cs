﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgrammingChallenge6._1.Models;

#nullable disable

namespace ProgrammingChallenge6._1.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20240221012430_Migration5")]
    partial class Migration5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProgrammingChallenge6._1.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClubId"));

                    b.Property<string>("ClubName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("No_of_Students")
                        .HasColumnType("int");

                    b.HasKey("ClubId");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("ProgrammingChallenge6._1.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ProgrammingChallenge6._1.Models.Enrolment", b =>
                {
                    b.Property<int>("EnrolmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrolmentID"));

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("clubId")
                        .HasColumnType("int");

                    b.HasKey("EnrolmentID");

                    b.HasIndex("StudentId");

                    b.HasIndex("clubId");

                    b.ToTable("Enrolments");
                });

            modelBuilder.Entity("ProgrammingChallenge6._1.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ProgrammingChallenge6._1.Models.Club", b =>
                {
                    b.HasOne("ProgrammingChallenge6._1.Models.Department", "Department")
                        .WithMany("Clubs")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ProgrammingChallenge6._1.Models.Enrolment", b =>
                {
                    b.HasOne("ProgrammingChallenge6._1.Models.Student", "Student")
                        .WithMany("Enrolments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProgrammingChallenge6._1.Models.Club", "club")
                        .WithMany()
                        .HasForeignKey("clubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("club");
                });

            modelBuilder.Entity("ProgrammingChallenge6._1.Models.Department", b =>
                {
                    b.Navigation("Clubs");
                });

            modelBuilder.Entity("ProgrammingChallenge6._1.Models.Student", b =>
                {
                    b.Navigation("Enrolments");
                });
#pragma warning restore 612, 618
        }
    }
}

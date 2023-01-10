﻿// <auto-generated />
using System;
using Ex_ample.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Example.Migrations
{
    [DbContext(typeof(ContextClass))]
    [Migration("20221214083816_mini")]
    partial class mini
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Ex_ample.Data.Entities.Doctors", b =>
                {
                    b.Property<string>("DoctorId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PassWord")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Qualification")
                        .HasColumnType("longtext");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Ex_ample.Data.Entities.ElifeSaverManagement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PassWord")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ElifeSaverManagements");
                });

            modelBuilder.Entity("Ex_ample.Data.Entities.NonMedicalStaff", b =>
                {
                    b.Property<string>("StaffId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PassWord")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Post")
                        .HasColumnType("longtext");

                    b.HasKey("StaffId");

                    b.ToTable("NonMedicalStaffs");
                });

            modelBuilder.Entity("Ex_ample.Data.Entities.Nurses", b =>
                {
                    b.Property<string>("NurseId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PassWord")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("Qualification")
                        .HasColumnType("longtext");

                    b.HasKey("NurseId");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("Ex_ample.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DoctorsDoctorId")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("ElifeSaverManagementId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("NonMedicalStaffStaffId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NursesNurseId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PassWord")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DoctorsDoctorId");

                    b.HasIndex("ElifeSaverManagementId");

                    b.HasIndex("NonMedicalStaffStaffId");

                    b.HasIndex("NursesNurseId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ex_ample.Data.Entities.User", b =>
                {
                    b.HasOne("Ex_ample.Data.Entities.Doctors", "Doctors")
                        .WithMany()
                        .HasForeignKey("DoctorsDoctorId");

                    b.HasOne("Ex_ample.Data.Entities.ElifeSaverManagement", "ElifeSaverManagement")
                        .WithMany()
                        .HasForeignKey("ElifeSaverManagementId");

                    b.HasOne("Ex_ample.Data.Entities.NonMedicalStaff", "NonMedicalStaff")
                        .WithMany()
                        .HasForeignKey("NonMedicalStaffStaffId");

                    b.HasOne("Ex_ample.Data.Entities.Nurses", "Nurses")
                        .WithMany()
                        .HasForeignKey("NursesNurseId");

                    b.Navigation("Doctors");

                    b.Navigation("ElifeSaverManagement");

                    b.Navigation("NonMedicalStaff");

                    b.Navigation("Nurses");
                });
#pragma warning restore 612, 618
        }
    }
}

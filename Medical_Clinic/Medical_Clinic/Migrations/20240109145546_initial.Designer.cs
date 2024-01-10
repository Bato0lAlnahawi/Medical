﻿// <auto-generated />
using Medical_Clinic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Medical_Clinic.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240109145546_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Medical_Clinic.Models.Doctors", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            DoctorName = "Ahmad Sami",
                            Specialty = "surgeon",
                            password = "1111"
                        },
                        new
                        {
                            DoctorId = 2,
                            DoctorName = "Sara Fadi",
                            Specialty = "general",
                            password = "2222"
                        },
                        new
                        {
                            DoctorId = 3,
                            DoctorName = "Majd Mohamad",
                            Specialty = "Pediatrician",
                            password = "3333"
                        });
                });

            modelBuilder.Entity("Medical_Clinic.Models.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MedicineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicineId");

                    b.ToTable("Medicine");

                    b.HasData(
                        new
                        {
                            MedicineId = 1,
                            MedicineName = "Paracetamol",
                            description = ""
                        },
                        new
                        {
                            MedicineId = 2,
                            MedicineName = "Acamol",
                            description = ""
                        },
                        new
                        {
                            MedicineId = 3,
                            MedicineName = "Panadol",
                            description = ""
                        },
                        new
                        {
                            MedicineId = 4,
                            MedicineName = "Aspirin",
                            description = ""
                        });
                });

            modelBuilder.Entity("Medical_Clinic.Models.Patients", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            PatientName = "Shooq Mohamad",
                            age = 21,
                            password = "1234"
                        },
                        new
                        {
                            PatientId = 2,
                            PatientName = "Shahed Anees",
                            age = 30,
                            password = "5678"
                        },
                        new
                        {
                            PatientId = 3,
                            PatientName = "Batool Ibrahem",
                            age = 20,
                            password = "4321"
                        });
                });

            modelBuilder.Entity("Medical_Clinic.Models.Prescription_Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<string>("MedicineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicineId", "PrescriptionId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("Prescription_Medicine");
                });

            modelBuilder.Entity("Medical_Clinic.Models.Prescriptions", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            PrescriptionId = 1,
                            DoctorId = 2,
                            DoctorName = "Sara Fadi",
                            PatientId = 3,
                            PatientName = "Batool Ibrahem"
                        });
                });

            modelBuilder.Entity("Medical_Clinic.Models.Prescription_Medicine", b =>
                {
                    b.HasOne("Medical_Clinic.Models.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Medical_Clinic.Models.Prescriptions", "Prescription")
                        .WithMany()
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Medical_Clinic.Models.Prescriptions", b =>
                {
                    b.HasOne("Medical_Clinic.Models.Doctors", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Medical_Clinic.Models.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

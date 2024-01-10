using Microsoft.EntityFrameworkCore;

namespace Medical_Clinic.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options )
            :base (options)
        { }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Prescriptions> Prescriptions { get; set; }
        public DbSet<Prescription_Medicine> Prescription_Medicine { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctors>().HasData(
                new Doctors { DoctorId = 1, DoctorName = "Ahmad Sami", Specialty = "surgeon", password = "1111" },
                new Doctors { DoctorId = 2, DoctorName = "Sara Fadi", Specialty = "general", password = "2222" },
                new Doctors { DoctorId = 3, DoctorName = "Majd Mohamad", Specialty = "Pediatrician", password = "3333" }
                );
            modelBuilder.Entity<Patients>().HasData(
                new Patients { PatientId = 1, PatientName = "Shooq Mohamad", age = 21, password = "1234" },
                new Patients { PatientId = 2, PatientName = "Shahed Anees", age = 30, password = "5678" },
                new Patients { PatientId = 3, PatientName = "Batool Ibrahem", age = 20, password = "4321" }
                );
            modelBuilder.Entity<Medicine>().HasData(
                new Medicine { MedicineId = 1, MedicineName = "Paracetamol", description = ""},
                new Medicine { MedicineId = 2, MedicineName = "Acamol", description = "" },
                new Medicine { MedicineId = 3, MedicineName = "Panadol", description = "" },
                new Medicine { MedicineId = 4, MedicineName = "Aspirin", description = "" }
                );
            modelBuilder.Entity<Prescriptions>().HasData(
                new Prescriptions { PrescriptionId = 1, DoctorId = 2,DoctorName ="Sara Fadi", PatientId = 3,PatientName ="Batool Ibrahem" }
                );
            //modelBuilder.Entity<Prescription_Medicine>().HasData(
               // new Prescription_Medicine { PrescriptionId = 1, MedicineId = 2,MedicineName ="Acamol",description="xyz"}
              // );
            modelBuilder.Entity<Prescription_Medicine>()
               .HasKey(pm => new { pm.MedicineId, pm.PrescriptionId });
        }
    }
}

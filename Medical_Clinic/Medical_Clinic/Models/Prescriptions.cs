using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medical_Clinic.Models
{
    public class Prescriptions
    {
        [Key]
        public int PrescriptionId { set; get; }
        public int DoctorId { set; get; }
        public string DoctorName { set; get; }
        public int PatientId { set; get; }
        public string PatientName { set; get; }
        public bool dispense { set; get; }

        [ForeignKey("DoctorId")]
        public Doctors Doctor { set; get; }

        [ForeignKey("PatientId")]
        public Patients Patient { set; get; }
    }
}

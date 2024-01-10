using System.ComponentModel.DataAnnotations;

namespace Medical_Clinic.Models
{
    public class Doctors
    {
        [Key]
        public int DoctorId { set; get; }
        public string DoctorName { set; get; }
        public string Specialty { set; get; }
        public string password { set; get; }
    }
}

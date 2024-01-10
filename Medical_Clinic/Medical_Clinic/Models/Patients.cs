using System.ComponentModel.DataAnnotations;

namespace Medical_Clinic.Models
{
    public class Patients
    {
        [Key]
        public int PatientId { set; get; }
        public string PatientName { set; get; }
        public int age { set; get; }
        public string password { set; get; }
    }
}

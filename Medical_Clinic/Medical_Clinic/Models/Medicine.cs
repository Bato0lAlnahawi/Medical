using System.ComponentModel.DataAnnotations;

namespace Medical_Clinic.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineId { set; get; }
        public string MedicineName { set; get; }
        public string description { set; get; }
    }
}

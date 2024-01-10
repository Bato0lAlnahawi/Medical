using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Medical_Clinic.Models
{
    public class Prescription_Medicine
    {
        [Key, Column(Order = 0)]
        public int PrescriptionId { set; get; }

        [Key, Column(Order = 1)]
        public int MedicineId { set; get; }
        public string MedicineName { set; get; }
        public string description { set; get; }

        [ForeignKey("MedicineId")]
        public Medicine Medicine { set; get; }

        [ForeignKey("PrescriptionId")]
        public Prescriptions Prescription { set; get; }
    }
}

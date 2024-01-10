using Medical_Clinic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Clinic.Controllers
{
    public class PatientController : Controller
    {
        private DatabaseContext context;
        public PatientController (DatabaseContext dtx)
        {
            context = dtx;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

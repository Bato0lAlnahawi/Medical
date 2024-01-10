using Medical_Clinic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Clinic.Controllers
{
    public class DoctorController : Controller
    {
        private DatabaseContext context;
        public DoctorController(DatabaseContext dtx)
        {
            context = dtx;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet] 
        public IActionResult Login() 
        { 
           // if(HttpContext.Session.GetInt32("drid")== null)
                return View();
           // return View("welcome");

        }
    }
}

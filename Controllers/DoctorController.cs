using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class DoctorController : Controller
    {
        SampleDataDoctor sample = new SampleDataDoctor();
        public IActionResult Index()
        {
            return View(sample.doctors.ToList());
        }
        public IActionResult BookAnAppointment(int id)
        {

            return View(sample.doctors.First(e=>e.Id==id));
        }
        
    }
}

using Application.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO;

namespace DEPI_Hospital_Project.Controllers
{
    public class PatientController : Controller
    {
        private IPatientService Service;
        public PatientController(IPatientService Service)
        {
            this.Service = Service;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PatientSignInViewModel model)
        {

        }
        public IActionResult AddPatient()
        {
            Service.AddNewPatient(new Patient
            {
                firstName = "Mohamed",
                lastName = "gaber"
            });
            return Ok();
        }

    }
}

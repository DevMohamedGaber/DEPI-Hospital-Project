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
            var patient = Service.GetPatientBySocialNumber(model);

            if(patient == null)
            {
                ModelState.AddModelError("SocialNumber", "no patient found that matches this social ID");
                return View();
            }

            ViewBag.Patient = patient;

            return View("info");
        }
    }
}

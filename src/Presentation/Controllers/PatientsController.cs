using Application.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DEPI_Hospital_Project.Controllers
{
    public class PatientsController : Controller
    {
        private IPatientService Service;
        public PatientsController(IPatientService Service)
        {
            this.Service = Service;
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

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}

using Application.Interfaces;
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

        public IActionResult Index()
        {
            return View();
        }
    }
}

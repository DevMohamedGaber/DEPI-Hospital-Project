using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO;

namespace Presentation.Controllers
{
    public class AdminController : Controller
    {
        IAppointmentService appointments;
        public AdminController(IAppointmentService appointments)
        {
            this.appointments = appointments;
        }
        public IActionResult Index()
        {
            ViewBag.Appointments = appointments.GetAll();
            return View();
        }

        public IActionResult AddNewPatient(PatientViewModel model)
        {

            return View(model);
        }
    }
}

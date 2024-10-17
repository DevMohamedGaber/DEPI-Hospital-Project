using Application.Interfaces;
using DataAccess.Entities;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO;

namespace Presentation.Controllers
{
    public class AdminController : Controller
    {
        IAppointmentService appointments;
        IStaffService staff;
        IPatientService patients;

        public AdminController(IAppointmentService appointments, IStaffService staff, IPatientService patients)
        {
            this.appointments = appointments;
            this.staff = staff;
            this.patients = patients;
        }
        public IActionResult Index()
        {
            ViewBag.Appointments = appointments.GetAll();
            ViewBag.Staff = staff.GetAll();
            return View();
        }
        public IActionResult AddPatient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPatient(PatientViewModel model)
        {
            patients.AddNewPatient(model);
            ModelState.AddModelError(string.Empty, "Added New Patient Successfully.");
            return View(model);
        }

        public IActionResult ViewPatient(int id)
        {
            Patient patient = patients.GetPatient((uint)id);
            if(patient == null)
            {
                return View("Index");
            }
            ViewBag.Patient = patient;
            return View();
        }
        #region Appointment
        public async Task<IActionResult> AddAppointment(int patientId)
        {
            ViewBag.patientId = patientId;
            ViewBag.Doctors = await staff.GetAllDoctors();
            return View();
        }

        [HttpPost]
        public IActionResult AddAppointment(AppointmentViewModel model)
        {
            //appointments.AddAppointment()
            return View(model);
        }
        #endregion
    }
}

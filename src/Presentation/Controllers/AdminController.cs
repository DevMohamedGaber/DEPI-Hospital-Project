using Application.Interfaces;
using DataAccess.Entities;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        #region Patients
        public IActionResult ViewPatients()
        {
            var patientsList = patients.GetAllPatients();
            ViewBag.Patients = patientsList;
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
        #endregion
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
            bool isAdded = appointments.AddAppointment(model);
            ModelState.AddModelError(string.Empty, isAdded ? "Added Successfully." : "Failed To Add new record.");
            return RedirectToAction("ViewPatient", new { id = model.PatientId });
        }
        #endregion
        #region Staff
        public async Task<IActionResult> ViewStaff()
        {
            ViewBag.Staff = await staff.GetAllWithRole();
            ViewBag.Roles = staff.GetAllRoles();
            return View();
        }
        public async Task<IActionResult> ViewStaffMember(int id)
        {
            if (id == 0)
            {
                return View("ViewStaff");
            }

            var user = await staff.GetUserWithRole((uint)id);

            if(user == null)
            {
                return View("ViewStaff");
            }

            ViewBag.Staff = user;
            return View();
        }
        public IActionResult AddStaffMember()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStaffMember(SignUpViewModel model)
        {

            return View();
        }
        #endregion
    }
}

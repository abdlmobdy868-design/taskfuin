using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly AppDbContext _context;
        public AppointmentController(AppDbContext context) { _context = context; }

        public IActionResult Index()
        {
            var appointments = _context.Appointments.Include(a => a.Doctor).OrderByDescending(a => a.AppointmentDate).ToList();
            return View(appointments);
        }



        [HttpGet]
        public IActionResult Create(int doctorId) 
        {
            var doctor = _context.Doctors.Find(doctorId);
            if (doctor == null) return NotFound();

            ViewBag.Doctor = doctor;
            ViewBag.TimeSlots = new List<string> { "09:00", "09:30", "10:00", "10:30", "11:00" }; 

            var appointment = new Appointment { DoctorId = doctorId };   
            appointment.DoctorId = doctorId;
            return View(appointment);
        }



        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            // 1. Date Restriction: Sunday to Thursday
            if (appointment.AppointmentDate.DayOfWeek == DayOfWeek.Friday || appointment.AppointmentDate.DayOfWeek == DayOfWeek.Saturday)
            {
                ModelState.AddModelError("", "Appointments are only available Sunday to Thursday");
            }

            // 2. Prevent Double Booking
            bool exists = _context.Appointments.Any(a =>
                a.DoctorId == appointment.DoctorId &&
                a.AppointmentDate.Date == appointment.AppointmentDate.Date &&
                a.AppointmentTime == appointment.AppointmentTime);

            if (exists)
                ModelState.AddModelError("", "This slot is already booked for this doctor");

            if (ModelState.IsValid)
            {
                _context.Appointments.Add(appointment);
                _context.SaveChanges();
                return RedirectToAction("Index","Doctor");
            }
            ViewBag.Doctor = _context.Doctors.Find(appointment.DoctorId);
            ViewBag.TimeSlots = new List<string> { "09:00", "09:30", "10:00", "10:30", "11:00" };
            return View(appointment);
        }

        private List<TimeSpan> GetTimeSlots()
        {
            var slots = new List<TimeSpan>();
            for (int i = 9; i <= 16; i++) 
            {
                slots.Add(new TimeSpan(i, 0, 0));
                slots.Add(new TimeSpan(i, 30, 0));
            }
            slots.Add(new TimeSpan(16, 30, 0)); 
            return slots;
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Appointment
    {
        [Required]
        public int Id { get; set; }
        public string PatientName { get; set; } = "";
        [Required]
        public DateTime AppointmentDate { get; set; }
        [Required]
        public string AppointmentTime { get; set; }

        [Required]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;
    }
}

namespace WebApplication2.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Specialization { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public List<Appointment> Appointments { get; set; } = new();
    }
}

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace Careoscope.Models
{
    public class Appointment
    {
        public int AppointmentID {get;set;} // PK

        [BindProperty]
        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime AppointmentDate {get;set;}

        [BindProperty(SupportsGet = true)]
        public DateTime CheckInTime {get;set;}

        [BindProperty(SupportsGet = true)]
        public DateTime CheckOutTime {get;set;}

        [BindProperty]
        [Display(Name = "Reason for Visit")]
        [StringLength(65, MinimumLength = 3)]
        [Required]
        public string? ReasonForVisit {get;set;}

        [BindProperty]
        [Display(Name = "Doctor's Notes")]
        [StringLength(65, MinimumLength = 3)]
        public string? DoctorNotes {get;set;}
        public Doctor Doctor {get;set;} = null!; // navigation property that connects to Doctor
        public int DoctorID {get;set;} // FK1
        public Patient Patient {get;set;} = null!; // navigation property that connects to Patient
        public int PatientID {get;set;} // FK2
    }
}
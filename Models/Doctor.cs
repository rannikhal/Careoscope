using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;


namespace Careoscope.Models
{
    public class Doctor
    {
        public int DoctorID {get;set;} // PK

        [BindProperty]
        [Display(Name = "First Name")]
        [StringLength(25)]
        [Required]
        public string? FirstName {get;set;}

        [BindProperty]
        [Display(Name = "Last Name")]
        [StringLength(25)]
        [Required]
        public string? LastName {get;set;}

        [BindProperty]
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime HireDate {get;set;}
        public List<Patient> Patients {get;set;} = new List<Patient>(); // navigation property that connects to Patient
        public List<Appointment> Appointments {get;set;} = new List<Appointment>(); // navigation property that connects to Appointment
    }
}
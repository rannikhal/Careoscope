using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace Careoscope.Models
{
    public class Patient
    {
        public int PatientID {get;set;} // PK

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
        [Display(Name = "Nickname")]
        [StringLength(25)]
        public string? Nickname {get;set;}

        [BindProperty]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth {get;set;}

        [BindProperty]
        [Display(Name = "Phone Number")]
        [Phone]
        [Required]
        public long PhoneNumber {get;set;}

        [BindProperty]
        [Display(Name = "E-mail")]
        [EmailAddress]
        [Required]
        public string? Email {get;set;}

        [BindProperty]
        [Display(Name = "Social Security Number")]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        [Required]
        public string? SocialSecurity {get;set;}

        [BindProperty]
        [Display(Name = "Gender")]
        [StringLength(1)]
        [Required]
        public char Gender {get;set;}

        [BindProperty]
        [Display(Name = "Insurance?")]
        [StringLength(1)]
        [Required]
        public char HasInsurance {get;set;}
        public Doctor Doctor {get;set;} = null!; // navigation property that connects to Doctor
        public int DoctorID {get;set;} // FK
        public List<Appointment> Appointments {get;set;} = new List<Appointment>(); // navigation property that connects to Appointment
    }
}
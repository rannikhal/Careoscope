using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace Careoscope.Models
{
    public class Appointment
    {
        public int AppointmentID {get;set;} // PK
        public DateTime AppointmentDate {get;set;}
        public DateTime CheckInTime {get;set;}
        public DateTime CheckOutTime {get;set;}
        public string? ReasonForVisit {get;set;}
        public string? DoctorNotes {get;set;}
        public Doctor Doctor {get;set;} = null!; // navigation property that connects to Doctor
        public int DoctorID {get;set;} // FK1
        public Patient Patient {get;set;} = null!; // navigation property that connects to Patient
        public int PatientID {get;set;} // FK2
    }
}
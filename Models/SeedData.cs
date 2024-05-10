using Microsoft.CodeAnalysis.Elfie.Model.Tree;
using Microsoft.EntityFrameworkCore;

namespace Careoscope.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CareoscopeDbContext(serviceProvider.GetRequiredService<DbContextOptions<CareoscopeDbContext>>()))
            {
                Doctor doctor1 = new Doctor
                {
                    FirstName = "Leia",
                    LastName = "Organa",
                    HireDate = new DateTime(1977, 5, 25),
                    Patients = new List<Patient>(),
                    Appointments = new List<Appointment>()
                };

                Doctor doctor2 = new Doctor
                {
                    FirstName = "Luke",
                    LastName = "Skywalker",
                    HireDate = new DateTime(1977, 5, 25),
                    Patients = new List<Patient>(),
                    Appointments = new List<Appointment>()
                };

                Patient patient1 = new Patient
                {
                    FirstName = "Eddard",
                    LastName = "Stark",
                    Nickname = "Ned",
                    DateOfBirth = new DateTime(),
                    PhoneNumber = 8815671902,
                    Email = "nedstark@westeros.com",
                    SocialSecurity = "242-87-9893",
                    Gender = 'M',
                    HasInsurance = 'Y',
                    Doctor = doctor1,
                    Appointments = new List<Appointment>()
                };

                Patient patient2 = new Patient
                {
                    FirstName = "Myrcella",
                    LastName = "Baratheon",
                    Nickname = "",
                    DateOfBirth = new DateTime(2011, 10, 10),
                    PhoneNumber = 7716686750,
                    Email = "myrcella@westeros.com",
                    SocialSecurity = "319-12-0458",
                    Gender = 'F',
                    HasInsurance = 'Y',
                    Doctor = doctor1,
                    Appointments = new List<Appointment>()
                };

                Patient patient3 = new Patient
                {
                    FirstName = "Sandor",
                    LastName = "Clegane",
                    Nickname = "The Hound",
                    DateOfBirth = new DateTime(1975, 5, 10),
                    PhoneNumber = 6866404204,
                    Email = "sclegane@westeros.com",
                    SocialSecurity = "612-95-4192",
                    Gender = 'M',
                    HasInsurance = 'N',
                    Doctor = doctor1,
                    Appointments = new List<Appointment>()
                };

                Patient patient4 = new Patient
                {
                    FirstName = "Viserys",
                    LastName = "Targaryen",
                    Nickname = "",
                    DateOfBirth = new DateTime(2000, 2, 1),
                    PhoneNumber = 3706290189,
                    Email = "viserys@westeros.com",
                    SocialSecurity = "124-46-3816",
                    Gender = 'M',
                    HasInsurance = 'Y',
                    Doctor = doctor1,
                    Appointments = new List<Appointment>()
                };

                Patient patient5 = new Patient
                {
                    FirstName = "Cersei",
                    LastName = "Lannister",
                    Nickname = "",
                    DateOfBirth = new DateTime(1988, 1, 18),
                    PhoneNumber = 7243070286,
                    Email = "cerseilannister@westeros.com",
                    SocialSecurity = "799-56-8962",
                    Gender = 'F',
                    HasInsurance = 'Y',
                    Doctor = doctor1,
                    Appointments = new List<Appointment>()
                };

                Patient patient6 = new Patient
                {
                    FirstName = "Jeor",
                    LastName = "Mormont",
                    Nickname = "",
                    DateOfBirth = new DateTime(1979, 7, 28),
                    PhoneNumber = 7091747904,
                    Email = "mormontjeor@westeros.com",
                    SocialSecurity = "719-72-6282",
                    Gender = 'M',
                    HasInsurance = 'N',
                    Doctor = doctor1,
                    Appointments = new List<Appointment>()
                };

                Patient patient7 = new Patient
                {
                    FirstName = "Meera",
                    LastName = "Reed",
                    Nickname = "",
                    DateOfBirth = new DateTime(2009, 8, 13),
                    PhoneNumber = 5705257727,
                    Email = "meera@westeros.com",
                    SocialSecurity = "744-01-5752",
                    Gender = 'F',
                    HasInsurance = 'Y',
                    Doctor = doctor1,
                    Appointments = new List<Appointment>()
                };

                Patient patient8 = new Patient
                {
                    FirstName = "Podrick",
                    LastName = "Payne",
                    Nickname = "",
                    DateOfBirth = new DateTime(1999, 11, 28),
                    PhoneNumber = 7277514369,
                    Email = "podpayne@westeros.com",
                    SocialSecurity = "420-79-8778",
                    Gender = 'M',
                    HasInsurance = 'Y',
                    Doctor = doctor1,
                    Appointments = new List<Appointment>()
                };

                Patient patient9 = new Patient
                {
                    FirstName = "Jon",
                    LastName = "Snow",
                    Nickname = "",
                    DateOfBirth = new DateTime(1998, 12, 18),
                    PhoneNumber = 1953627876,
                    Email = "snowman@westeros.com",
                    SocialSecurity = "641-43-8796",
                    Gender = 'M',
                    HasInsurance = 'N',
                    Doctor = doctor2,
                    Appointments = new List<Appointment>()
                };

                Patient patient10 = new Patient
                {
                    FirstName = "Khal",
                    LastName = "Drogo",
                    Nickname = "",
                    DateOfBirth = new DateTime(1985, 3, 8),
                    PhoneNumber = 5623342803,
                    Email = "bigkhal@westeros.com",
                    SocialSecurity = "778-21-4719",
                    Gender = 'M',
                    HasInsurance = 'N',
                    Doctor = doctor2,
                    Appointments = new List<Appointment>()
                };

                Patient patient11 = new Patient
                {
                    FirstName = "Yara",
                    LastName = "Greyjoy",
                    Nickname = "",
                    DateOfBirth = new DateTime(2002, 4, 12),
                    PhoneNumber = 2145748664,
                    Email = "yara02@westeros.com",
                    SocialSecurity = "504-20-9605",
                    Gender = 'F',
                    HasInsurance = 'Y',
                    Doctor = doctor2,
                    Appointments = new List<Appointment>()
                };

                Patient patient12 = new Patient
                {
                    FirstName = "Daario",
                    LastName = "Naharis",
                    Nickname = "",
                    DateOfBirth = new DateTime(1990, 4, 17),
                    PhoneNumber = 3151065099,
                    Email = "daario1@westeros.com",
                    SocialSecurity = "249-12-7468",
                    Gender = 'M',
                    HasInsurance = 'N',
                    Doctor = doctor2,
                    Appointments = new List<Appointment>()
                };

                Patient patient13 = new Patient
                {
                    FirstName = "Talisa",
                    LastName = "Maegyr",
                    Nickname = "",
                    DateOfBirth = new DateTime(2001, 10, 8),
                    PhoneNumber = 5872651886,
                    Email = "talisa@westeros.com",
                    SocialSecurity = "524-11-5323",
                    Gender = 'F',
                    HasInsurance = 'Y',
                    Doctor = doctor2,
                    Appointments = new List<Appointment>()
                };

                Patient patient14 = new Patient
                {
                    FirstName = "Margaery",
                    LastName = "Tyrell",
                    Nickname = "",
                    DateOfBirth = new DateTime(2003, 10, 11),
                    PhoneNumber = 9420432095,
                    Email = "flowerhead@westeros.com",
                    SocialSecurity = "406-95-0116",
                    Gender = 'F',
                    HasInsurance = 'Y',
                    Doctor = doctor2,
                    Appointments = new List<Appointment>()
                };

                Patient patient15 = new Patient
                {
                    FirstName = "Meryn",
                    LastName = "Trant",
                    Nickname = "",
                    DateOfBirth = new DateTime(1959, 6, 9),
                    PhoneNumber = 4038871263,
                    Email = "meryn@westeros.com",
                    SocialSecurity = "758-31-1298",
                    Gender = 'M',
                    HasInsurance = 'Y',
                    Doctor = doctor2,
                    Appointments = new List<Appointment>()
                };

                Appointment appo1 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient1,
                    AppointmentDate = new DateTime(2024, 5, 9, 13, 0, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = "Everything looks normal."
                };

                Appointment appo2 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient1,
                    AppointmentDate = new DateTime(2024, 5, 2, 8, 0, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = ""
                };

                Appointment appo3 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient1,
                    AppointmentDate = new DateTime(2023, 5, 9, 13, 0, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = "Cholesterol is high."
                };

                Appointment appo4 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient1,
                    AppointmentDate = new DateTime(2023, 5, 2, 8, 0, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = ""
                };

                Appointment appo5 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient2,
                    AppointmentDate = new DateTime(2024, 5, 9, 13, 30, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = "All good."
                };

                Appointment appo6 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient2,
                    AppointmentDate = new DateTime(2024, 5, 2, 9, 0, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = ""
                };

                Appointment appo7 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient3,
                    AppointmentDate = new DateTime(2024, 6, 3, 13, 0, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = ""
                };

                Appointment appo8 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient3,
                    AppointmentDate = new DateTime(2024, 5, 27, 8, 0, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = ""
                };

                Appointment appo9 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient3,
                    AppointmentDate = new DateTime(2024, 5, 9, 11, 0, 0),
                    ReasonForVisit = "Illness",
                    DoctorNotes = ""
                };

                Appointment appo10 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient4,
                    AppointmentDate = new DateTime(2024, 5, 9, 9, 30, 0),
                    ReasonForVisit = "STD Testing",
                    DoctorNotes = ""
                };

                Appointment appo11 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient4,
                    AppointmentDate = new DateTime(2024, 5, 14, 15, 0, 0),
                    ReasonForVisit = "Test Results",
                    DoctorNotes = ""
                };

                Appointment appo12 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient5,
                    AppointmentDate = new DateTime(2024, 5, 10, 11, 0, 0),
                    ReasonForVisit = "Vaccinations",
                    DoctorNotes = "Vaccinations to travel to Dorne."
                };

                Appointment appo13 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient6,
                    AppointmentDate = new DateTime(2024, 5, 10, 14, 0, 0),
                    ReasonForVisit = "Illness",
                    DoctorNotes = "Skin concerns."
                };

                Appointment appo14 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient7,
                    AppointmentDate = new DateTime(2024, 5, 10, 15, 0, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = ""
                };

                Appointment appo15 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient7,
                    AppointmentDate = new DateTime(2024, 5, 3, 8, 0, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = "Low iron."
                };

                Appointment appo16 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient7,
                    AppointmentDate = new DateTime(2024, 3, 6, 10, 30, 0),
                    ReasonForVisit = "Illness",
                    DoctorNotes = "Had a cold. Prescribed medication."
                };

                Appointment appo17 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient7,
                    AppointmentDate = new DateTime(2023, 12, 5, 14, 0, 0),
                    ReasonForVisit = "Follow-Up",
                    DoctorNotes = "Medication change has been working."
                };

                Appointment appo18= new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient7,
                    AppointmentDate = new DateTime(2023, 9, 5, 9, 30, 0),
                    ReasonForVisit = "Follow-Up",
                    DoctorNotes = "Increased dose of medication."
                };

                Appointment appo19 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient8,
                    AppointmentDate = new DateTime(2024, 5, 9, 15, 30, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = ""
                };

                Appointment appo20 = new Appointment
                {
                    Doctor = doctor1,
                    Patient = patient8,
                    AppointmentDate = new DateTime(2024, 5, 1, 8, 30, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = ""
                };

                Appointment appo21 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient9,
                    AppointmentDate = new DateTime(2024, 5, 9, 8, 0, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = ""
                };

                Appointment appo22 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient9,
                    AppointmentDate = new DateTime(2024, 5, 16, 13, 0, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = ""
                };

                Appointment appo23 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient9,
                    AppointmentDate = new DateTime(2023, 12, 19, 11, 0, 0),
                    ReasonForVisit = "Vaccinations",
                    DoctorNotes = "Travel vaccionations for scheduled travel to the Wall."
                };

                Appointment appo24 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient10,
                    AppointmentDate = new DateTime(2024, 5, 9, 8, 30, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = ""
                };

                Appointment appo25 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient10,
                    AppointmentDate = new DateTime(2024, 5, 17, 14, 0, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = ""
                };

                Appointment appo26 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient10,
                    AppointmentDate = new DateTime(2024, 4, 17, 11, 0, 0),
                    ReasonForVisit = "Vaccinations",
                    DoctorNotes = "Tetanus shot."
                };

                Appointment appo27 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient11,
                    AppointmentDate = new DateTime(2024, 5, 6, 9, 0, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = ""
                };

                Appointment appo28 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient11,
                    AppointmentDate = new DateTime(2024, 5, 13, 13, 0, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = ""
                };

                Appointment appo29 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient12,
                    AppointmentDate = new DateTime(2024, 5, 6, 10, 0, 0),
                    ReasonForVisit = "STD Testing",
                    DoctorNotes = ""
                };

                Appointment appo30 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient12,
                    AppointmentDate = new DateTime(2024, 5, 9, 10, 0, 0),
                    ReasonForVisit = "Test Results",
                    DoctorNotes = ""
                };

                Appointment appo31 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient13,
                    AppointmentDate = new DateTime(2024, 3, 10, 10, 0, 0),
                    ReasonForVisit = "Follow-Up",
                    DoctorNotes = "Increased medication dose."
                };

                Appointment appo32 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient13,
                    AppointmentDate = new DateTime(2024, 6, 4, 8, 0, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = ""
                };

                Appointment appo33 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient13,
                    AppointmentDate = new DateTime(2024, 6, 11, 11, 0, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = ""
                };

                Appointment appo34 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient14,
                    AppointmentDate = new DateTime(2024, 2, 16, 9, 0, 0),
                    ReasonForVisit = "STD Testing",
                    DoctorNotes = ""
                };

                Appointment appo35 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient14,
                    AppointmentDate = new DateTime(2024, 2, 19, 11, 0, 0),
                    ReasonForVisit = "Test Results",
                    DoctorNotes = ""
                };

                Appointment appo36 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient14,
                    AppointmentDate = new DateTime(2024, 7, 10, 13, 30, 0),
                    ReasonForVisit = "Vaccinations",
                    DoctorNotes = ""
                };

                Appointment appo37 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient14,
                    AppointmentDate = new DateTime(2023, 8, 18, 14, 30, 0),
                    ReasonForVisit = "Illness",
                    DoctorNotes = ""
                };

                Appointment appo38 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient15,
                    AppointmentDate = new DateTime(2024, 5, 9, 16, 0, 0),
                    ReasonForVisit = "Annual Well Check",
                    DoctorNotes = ""
                };

                Appointment appo39 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient15,
                    AppointmentDate = new DateTime(2024, 5, 2, 9, 30, 0),
                    ReasonForVisit = "Labs",
                    DoctorNotes = ""
                };

                Appointment appo40 = new Appointment
                {
                    Doctor = doctor2,
                    Patient = patient15,
                    AppointmentDate = new DateTime(2023, 11, 7, 10, 30, 0),
                    ReasonForVisit = "Illness",
                    DoctorNotes = ""
                };
                
                
                // checking if there's any records in the Doctor table. if not, it seeds the database. 
                if (context.Doctors.Any())
                {
                }
                else
                {
                    context.Doctors.AddRange(doctor1, doctor2);
                }
                context.SaveChanges();

                // checking if there's any records in the Patient table. if not, it seeds the database. 
                if (context.Patients.Any())
                {
                }
                else
                {
                    context.Patients.AddRange(patient1, patient2, patient3, patient4, patient5, patient6, patient7, patient8, patient9, patient10, patient11, patient12, patient13, patient14, patient15);
                }
                context.SaveChanges();

                // checking if there's any records in the Appointment table. if not, it seeds the database. 
                if (context.Appointments.Any())
                {
                }
                else
                {
                    context.Appointments.AddRange(appo1, appo2, appo3, appo4, appo5, appo6, appo7, appo8, appo9, appo10, appo11, appo12, appo13, appo14, appo15, appo16, appo17, appo18, appo19, appo20, appo21, appo22, appo23, appo24, appo25, appo26, appo27, appo28, appo29, appo30, appo31, appo32, appo33, appo34, appo35, appo36, appo37, appo38, appo39, appo40);
                }
                context.SaveChanges();
            }
        }
    }
}
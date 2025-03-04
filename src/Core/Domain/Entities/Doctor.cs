using Healthcare.Domain.Entities.Common;
using System.Collections.Generic;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Doctor : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    

    public string LicenseNumber { get; set; }
    public string ImageUrl { get; set; }
    public DateTime DateOfBirth { get; set; }
   
    public DateTime ShiftStart { get; set; }
    public DateTime ShiftEnd { get; set; }
    
    public Specialization Specialization { get; set; }
    public Department Department { get; set; }
    public DoctorTitle Title { get; set; }
    public DoctorStatus Status { get; set; }
    public ShiftType ShiftType { get; set; }
    public List<Language> Languages { get; set; }
    public List<Certification> Certifications { get; set; } 
    
    public int MaxAppointmentsPerDay { get; set; }
    public string Bio { get; set; }
    public string Education { get; set; }


    public List<Patient> Patients { get; set; } 
    public List<Appointment> Appointments { get; set; } 
    public List<MedicalRecord> MedicalRecords { get; set; } 
}
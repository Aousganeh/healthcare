using Healthcare.Domain.Entities.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Patient : BaseEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public BloodType BloodType { get; set; }
    
    public int RoomId { get; set; }
    public Room Room { get; set; }
    
    public List<Allergy> Allergies { get; set; }
    public List<Appointment> Appointments { get; set; }
    public List<TestResult> TestResults { get; set; }
    public List<Prescription> Prescriptions { get; set; }
    public List<Insurance> Insurances { get; set; }
}
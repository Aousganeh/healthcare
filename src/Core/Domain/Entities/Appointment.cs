using Healthcare.Domain.Entities.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Appointment : BaseEntity
{
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public AppointmentStatus Status { get; set; }
    public bool IsConfirmed { get; set; } 

    public string Notes { get; set; }
    public string Reason { get; set; }

    public AppointmentType Type { get; set; }
    public AppointmentPriority Priority { get; set; }
    
    public string Location { get; set; }
    
    public bool ReminderSent { get; set; } 

    public string CancellationReason { get; set; }
    public bool Attended { get; set; }
    
    public Payment Payment { get; set; }
    
    public string CreatedBy { get; set; }
    public bool IsRecurring { get; set; } 
}
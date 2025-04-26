using Healthcare.Domain.Entities.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Symptom : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    public SymptomSeverity Severity { get; set; } 
    public DateTime OnsetDate { get; set; }
    
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
    
    public bool IsActive { get; set; }
    public string Notes { get; set; }
}
using Healthcare.Domain.Entities.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Allergy : BaseEntity
{
    public string Name { get; set; }
    public List<string> Substances { get; set; }
    public string Notes { get; set; }

    public List<Symptom> ReactionSymptoms { get; set; }

    public AllergyType Type { get; set; }
    public AllergySeverity Severity { get; set; }

    public DateTime IdentifiedDate { get; set; }
    public bool IsLifeThreatening { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; }
}
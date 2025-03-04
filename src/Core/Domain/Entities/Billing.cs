using Healthcare.Domain.Entities.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Billing : BaseEntity
{
    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }

    public string InvoiceNumber { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal PaidAmount => Payments?.Sum(p => p.Amount) ?? 0;
    public decimal RemainingAmount => TotalAmount - PaidAmount;

    public BillingStatus Status { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }

    public List<Payment> Payments { get; set; }

    public string Description { get; set; }
    public List<string> ItemizedCharges { get; set; }
}
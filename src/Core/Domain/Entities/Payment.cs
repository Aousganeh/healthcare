using Healthcare.Domain.Entities.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Payment : BaseEntity
{
    public int BillingId { get; set; }
    public Billing Billing { get; set; }

    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public PaymentMethod Method { get; set; }
    public PaymentStatus Status { get; set; }

    public string TransactionId { get; set; }
    public string Notes { get; set; }

    public string PayerName { get; set; }
    public string PayerContactInfo { get; set; }
}
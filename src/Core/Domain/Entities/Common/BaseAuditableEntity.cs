﻿namespace Healthcare.Domain.Entities.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    public string? CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime LastModifiedOn { get; set; }
}
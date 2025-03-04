using Healthcare.Domain.Entities.Common;
using System;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Equipment : BaseEntity
{
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public EquipmentType Type { get; set; }
    public EquipmentStatus Status { get; set; }
    public DateTime PurchaseDate { get; set; }
    public DateTime? LastMaintenanceDate { get; set; }
    public DateTime? NextMaintenanceDate { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Notes { get; set; }

    public int? RoomId { get; set; }
    public Room Room { get; set; }

    public int? VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }

    public int? DepartmentId { get; set; }
    public Department Department { get; set; }
}
using System;
using System.Threading.Tasks;

namespace Healthcare.Application.Contracts.Persistence;

public interface IUnitOfWork : IDisposable
{
    IDoctorRepository DoctorRepository { get; }
    IEquipmentRepository EquipmentRepository { get; }
    INurseRepository NurseRepository { get; }
    IParamedicRepository ParamedicRepository { get; }
    IVehicleRepository VehicleRepository { get; }
    IRoomRepository RoomRepository { get; }
    IPatientRepository PatientRepository { get; }
    IBillingRepository BillingRepository { get; }
    IAllergyRepository AllergyRepository { get; }
    IAppointmentRepository AppointmentRepository { get; }
    IInsuranceRepository InsuranceRepository { get; }
    ILaboratoryRepository LaboratoryRepository { get; }
    IPharmacyRepository PharmacyRepository { get; }
    IPrescriptionRepository PrescriptionRepository { get; }
    ISymptomRepository SymptomRepository { get; }
    ITestResultRepository TestResultRepository { get; }

    Task SaveAsync();
}
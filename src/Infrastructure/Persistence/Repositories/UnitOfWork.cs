using System.Security.Claims;
using Healthcare.Application.Contracts.Persistence;
using Microsoft.AspNetCore.Http;

namespace Healthcare.Persistence.Repositories;

public class UnitOfWork
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly HealthcareDbContext _dbContext;
    
    private IAllergyRepository _allergyRepository;
    private IAppointmentRepository _appointmentRepository;
    private IBillingRepository _billingRepository;
    private IDoctorRepository _doctorRepository;
    private IEquipmentRepository _equipmentRepository;
    private IInsuranceRepository _insuranceRepository;
    private ILaboratoryRepository _laboratoryRepository;
    private INurseRepository _nurseRepository;
    private IPatientRepository _patientRepository;
    private IParamedicRepository _paramedicRepository;
    private IPharmacyRepository _pharmacyRepository;
    private IPrescriptionRepository _prescriptionRepository;
    private IRoomRepository _roomRepository;
    private ISymptomRepository _symptomRepository;
    private ITestResultRepository _testResultRepository;
    private IVehicleRepository _vehicleRepository;
    
    public UnitOfWork(HealthcareDbContext dbContext, IHttpContextAccessor httpContextAccessor)
    {
        _dbContext = dbContext;
        _httpContextAccessor = httpContextAccessor;
    }
    
    public IAllergyRepository AllergyRepository => _allergyRepository ??= new AllergyRepository(_dbContext);
    public IAppointmentRepository AppointmentRepository => _appointmentRepository ??= new AppointmentRepository(_dbContext);
    public IBillingRepository BillingRepository => _billingRepository ??= new BillingRepository(_dbContext);
    public IDoctorRepository DoctorRepository => _doctorRepository ??= new DoctorRepository(_dbContext);
    public IEquipmentRepository EquipmentRepository => _equipmentRepository ??= new EquipmentRepository(_dbContext);
    public IInsuranceRepository InsuranceRepository => _insuranceRepository ??= new InsuranceRepository(_dbContext);
    public ILaboratoryRepository LaboratoryRepository => _laboratoryRepository ??= new LaboratoryRepository(_dbContext);
    public INurseRepository NurseRepository => _nurseRepository ??= new NurseRepository(_dbContext);
    public IPatientRepository PatientRepository => _patientRepository ??= new PatientRepository(_dbContext);
    public IParamedicRepository ParamedicRepository => _paramedicRepository ??= new ParamedicRepository(_dbContext);
    public IPharmacyRepository PharmacyRepository => _pharmacyRepository ??= new PharmacyRepository(_dbContext);
    public IPrescriptionRepository PrescriptionRepository => _prescriptionRepository ??= new PrescriptionRepository(_dbContext);
    public IRoomRepository RoomRepository => _roomRepository ??= new RoomRepository(_dbContext);
    public ISymptomRepository SymptomRepository => _symptomRepository ??= new SymptomRepository(_dbContext);
    public ITestResultRepository TestResultRepository => _testResultRepository ??= new TestResultRepository(_dbContext);
    public IVehicleRepository VehicleRepository => _vehicleRepository ??= new VehicleRepository(_dbContext);
    
    public async Task SaveAsync()
    {
        var username = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        await _dbContext.SaveChangesAsync(username);
    }
    
    public void Dispose()
    {
        _dbContext.Dispose();
        GC.SuppressFinalize(this);
    }
}
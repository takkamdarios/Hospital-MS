using Hospital.BO.Entities;

namespace Hospital.BL.DTO.In;

public  class LabTestIn : BaseIn<LabTestEntity>
{
    public string? LabTestName { get; set; }
    public PatientEntity? LabPatientName { get; set; }
    public EmployeeEntity? LabEmployeeName { get; set; }
    public override LabTestEntity ConvertToEntity()
    {
        return new LabTestEntity()
        {
            TestName = LabTestName,
            PatientName = LabPatientName,
            EmployeeName = LabEmployeeName
        };
    }
}
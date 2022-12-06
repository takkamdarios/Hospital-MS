using Hospital.BO.Entities;

namespace Hospital.BL.DTO.Out;

public class LabTestOut
{
    public string? LabTestName { get; set; }
    public PatientEntity? LabPatientName { get; set; }
    public EmployeeEntity? LabEmployeeName { get; set; }
}
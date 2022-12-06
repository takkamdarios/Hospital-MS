namespace Hospital.BO.Entities;

public  class LabTestEntity
{
    public int TestId { get; set; }
    public string? TestName { get; set; }
    public bool IsActive { get; set; }
    public PatientEntity? PatientName { get; set; }
    public EmployeeEntity? EmployeeName { get; set; }
    public string? Description { get; set; }
}
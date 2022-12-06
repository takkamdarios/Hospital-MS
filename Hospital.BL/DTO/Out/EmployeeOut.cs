using Hospital.BO.Entities;
namespace Hospital.BL.DTO.Out;

public class EmployeeOut : PersonOut
{
    public string? Specialization { get; set; }
    public float Salary { get; set; }
    public string? RoleName { get; set; }
    
    public IList<PatientOut> Patients { get; set; }
    
    public PersonEntity ConvertToEntity()
    {
        return new PatientEntity()
        {
            FirstName = FirstName,
            LastName = LastName
        };
    }
}


namespace Hospital.BL.DTO.In;

public class EmployeeIn : BaseIn<PersonIn> 
{
    public string? Specialization { get; set; }
    public float Salary { get; set; }
    public string? RoleName { get; set; }

    public override PersonIn ConvertToEntity()
    {
        return new PersonIn()
        {
            Specialization = Specialization,
            Salary = Salary,
            RoleName = RoleName
        };
    }
}
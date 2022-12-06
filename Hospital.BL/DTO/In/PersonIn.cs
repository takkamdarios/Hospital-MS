using Hospital.BO.Entities;

namespace Hospital.BL.DTO.In;

public class PersonIn : BaseIn<PersonEntity>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public string? Specialization { get; set; }
    public float Salary { get; set; }
    public string? RoleName { get; set; }
    public override PersonEntity ConvertToEntity()
    {
        return new PatientEntity()
        {
            FirstName = FirstName,
            LastName = LastName,
            Address = Address
        };
    }
}
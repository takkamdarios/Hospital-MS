using Hospital.BO.Entities;

namespace Hospital.BL.DTO.Out;

public class PersonOut
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? RoleName { get; set; }
    public PersonEntity ConvertToEntity()
    {
        return new PatientEntity()
        {
            FirstName = FirstName,
            LastName = LastName
        };
    }

}
using Hospital.BO.Entities;

namespace Hospital.BL.DTO.Out;

public class PatientOut : PersonOut
{
    public float Amount { get; set; }
    public string? PatientName { get; set; }
    public int RoomNo { get; set; }
    public string? Location { get; set; }
    
    public PersonEntity ConvertToEntity()
    {
        return new PatientEntity()
        {
            FirstName = FirstName,
            LastName = LastName
        };
    }
    
}
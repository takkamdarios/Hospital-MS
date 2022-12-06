using Hospital.BO.Entities;

namespace Hospital.BL.DTO.In;

public class PatientIn : PersonIn
{
    public float Amount { get; set; }
    public string? PatientName { get; set; }
    public int RoomNo { get; set; }
    public string? Location { get; set; }
    
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
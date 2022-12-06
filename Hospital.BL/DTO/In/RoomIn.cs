namespace Hospital.BL.DTO.In;

public class RoomIn : BaseIn<PatientIn>
{
     public int RoomNo { get; set; }
     public string? Location { get; set; }
     
    public override PatientIn ConvertToEntity()
    {
        return new PatientIn()
        {
            RoomNo = RoomNo,
            Location = Location
        };

    }
}
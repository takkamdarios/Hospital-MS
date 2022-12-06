namespace Hospital.BL.DTO.In;

public class BillIn : BaseIn<PatientIn>
{
    public float Amount { get; set; }
    public string? PatientName { get; set; }
    
    public override PatientIn ConvertToEntity()
    {
        return new PatientIn()
        {
            Amount = Amount,
            PatientName = PatientName
        };
    }
}
namespace Hospital.BO.Entities;

public class BillEntity
{
    public float Amount { get; set; }
    public string? PatientName { get; set; }
    public int BillNo { get; set; }
}
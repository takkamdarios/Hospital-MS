namespace Hospital.BO.Entities
{
    public class PatientEntity : PersonEntity
    {
        public int RoomNo { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime DateDischarge { get; set; }
        public int DiseasesId { get; set; }
        public string? Disease { get; set; }
        public string? Drugs { get; set; }
    }
}

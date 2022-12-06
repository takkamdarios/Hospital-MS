namespace Hospital.BO.Entities;

public abstract class EmployeeEntity : PersonEntity
{
    public string? Specialization { get; set; }
    public float Salary { get; set; }
    public int RoleId { get; set; }
    public string? RoleName { get; set; }
    public ICollection<RoomEntity>? Room { get; set; }
}
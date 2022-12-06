namespace Hospital.BL.DTO.In;


public abstract class BaseIn<TEntity>
{
    public int Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public abstract TEntity ConvertToEntity();
}
namespace Hospital.BL.DTO.Out;

public class BaseOut<TEntity , TOut>
    where TOut : class, TEntity  
{
    public int Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }

    public static TOut CnvertToOut(TEntity entity)
    {
        return null;
    }
}


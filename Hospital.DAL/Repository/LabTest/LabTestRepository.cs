using Hospital.BO.Entities;
using Hospital.DAL.Repository.Base;

namespace Hospital.DAL.Repository.LabTest;

public class LabTestRepository : BaseRepository<PersonEntity> , ILabTestRepository
{
    
}
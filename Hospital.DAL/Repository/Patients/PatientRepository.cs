
using Hospital.BO.Entities;
using Hospital.DAL.Repository.Base;

namespace Hospital.DAL.Repository.Patient
{
    public class PatientRepository : BaseRepository<PersonEntity> , IPatientRepository
    {
    }
}

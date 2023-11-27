//adjust according to the actual devtools structure
using DevTools.ADO.Repository
using Hospital.BL.Business;

namespace Hospital.BL.Business.Patient
{
    public class PatientBL :IPatientBL
    {
        private readonly IContactRepository _contactRepository;

        public PatientBL(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
    }
}

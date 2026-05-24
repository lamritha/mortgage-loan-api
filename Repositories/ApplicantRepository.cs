using MortgageLoanAPI.Models;

namespace MortgageLoanAPI.Repositories
{
    public class ApplicantRepository :IApplicantRepository {
        public ApplicantRepository() { }
        public async Task<Applicant?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Applicant>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<Applicant> CreateAsync(Applicant applicant)
        {
            throw new NotImplementedException();
        }
    }

}


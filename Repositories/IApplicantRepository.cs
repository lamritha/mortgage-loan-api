using MortgageLoanAPI.Models;

namespace MortgageLoanAPI.Repositories { 
    public interface IApplicantRepository
    {
        Task<Applicant?> GetByIdAsync(int id);
        Task<List<Applicant>> GetAllAsync();
        Task<Applicant> CreateAsync(Applicant applicant);
    }
}

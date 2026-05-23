using MortgageLoanAPI.Models;

namespace MortgageLoanAPI.Repositories
{
    public interface ILoanApplicationRepository
    {
        Task<LoanApplication?> GetByIdAsync(int id);
        Task<List<LoanApplication>> GetByApplicantIdAsync(int applicantId);
        Task<LoanApplication> CreateAsync(LoanApplication application);
        Task<LoanApplication> UpdateAsync(LoanApplication application);
    }
}

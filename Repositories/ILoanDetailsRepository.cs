using MortgageLoanAPI.Models;

namespace MortgageLoanAPI.Repositories
{
    public interface ILoanDetailsRepository
    {
        Task<LoanDetails?> GetByApplicationIdAsync(int applicationId);
        Task<LoanDetails> CreateAsync(LoanDetails loanDetails);
    }
}

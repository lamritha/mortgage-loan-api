using MortgageLoanAPI.Models;

namespace MortgageLoanAPI.Repositories
{
    public interface IRepaymentScheduleRepository
    {
        Task<List<RepaymentSchedule>> GetByLoanDetailsIdAsync(int loanDetailsId);
        Task CreateManyAsync(List<RepaymentSchedule> schedules);
    }
}

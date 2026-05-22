
namespace MortgageLoanAPI.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal AnnualIncome { get; set; }
        public decimal CreditScore { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

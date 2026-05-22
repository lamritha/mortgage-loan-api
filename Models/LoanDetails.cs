namespace MortgageLoanAPI.Models
{
    public class LoanDetails {
        public int Id { get; set; }
        public int LoanApplicationId { get; set; }
        public LoanApplication LoanApplication { get; set; } = null!;
        public decimal LoanAmount { get; set; }
        public decimal InterestRate { get; set; }
        public decimal MonthlyPayment { get; set; }
    }
}

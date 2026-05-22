namespace MortgageLoanAPI.Models
{
    public class RepaymentSchedule
    {
        public int Id { get; set; }
        public int LoanDetailsId { get; set; }
        public LoanDetails LoanDetails { get; set; } = null!;
        public int PaymentNumber { get; set; }
        public decimal Principal {  get; set; }
        public decimal Interest { get; set; }
        public decimal RemainingBalance { get; set; }
    }
}

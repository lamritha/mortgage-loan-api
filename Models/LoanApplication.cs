namespace MortgageLoanAPI.Models
{
    public class LoanApplication
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; } = null!;
        public decimal PropertyValue { get; set; }
        public decimal DownPayment { get; set; }
        public int LoanTermYears { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}

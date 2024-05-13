namespace Ticketly.Domain.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public int PaymentMenthodId { get; set; }

        public LookupPaymentMethod PaymentMethod { get; set; }
    }
}

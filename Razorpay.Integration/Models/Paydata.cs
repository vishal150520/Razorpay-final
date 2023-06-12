namespace Razorpay.Integration.Models
{
    public class Paydata
    {
        public int Id { get; set; }
        public string order_id { get; set; }
        public string payment_id { get; set; }
        public string signature { get; set; }
        public string status { get; set; }

    }
}

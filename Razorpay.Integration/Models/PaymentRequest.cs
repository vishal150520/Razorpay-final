using System.ComponentModel.DataAnnotations;

namespace Razorpay.Integration.Models
{
    public class PaymentRequest
    {
        [Key]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}

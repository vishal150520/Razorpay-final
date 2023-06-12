﻿using System.ComponentModel.DataAnnotations;

namespace Razorpay.Integration.Models
{
    public class PaymentRequest
    {
        [Key]
        public int Id { get; set; }
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

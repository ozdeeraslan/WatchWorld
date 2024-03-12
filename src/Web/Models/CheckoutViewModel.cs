﻿using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class CheckoutViewModel
    {
        public BasketViewModel? Basket  { get; set; }

        [Required]
        [MaxLength(180)]
        public string Street { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string City { get; set; } = null!;

        [MaxLength(60)]
        public string? State { get; set; } 

        [Required]
        [MaxLength(90)]
        public string Country { get; set; } = null!;

        [Required]
        [MaxLength(18)]
        [Display(Name = "Zip")]
        public string Zipcode { get; set; } = null!; 

        [Required]
        [Display(Name = "Name on card")]
        public string CCHolder { get; set; } = null!; 

        [Required]
        [CreditCard]
        [Display(Name = "Credit card number")]
        public string CCNumber { get; set; } = null!; 


        [Required]
        [Display(Name = "Expiration")]
        [RegularExpression(@"^[0-9]{2}\/[0-9]{2}$", ErrorMessage = "Invalid {0}.")]
        public string CCExpiration { get; set; } = null!;

        [Required]
        [Display(Name = "CVV")]
        [RegularExpression(@"^[0-9]{3}$", ErrorMessage = "Invalid {0}.")]
        public string CCCvv { get; set; } = null!;



    }
}

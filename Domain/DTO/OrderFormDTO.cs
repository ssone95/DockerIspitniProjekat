using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.DTO
{
    public class OrderFormDTO
    {
        [Required(ErrorMessage = "First Name is required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required!")]
        public string LastName { get; set; }
        public string Company { get; set; }
        [Required(ErrorMessage = "Country is required!")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Address is required!")]
        public string Address { get; set; }
        public string Address2 { get; set; }
        [Required(ErrorMessage = "Zip Code is required!")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "City is required!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Phone Number is required!")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        public string EmailAddress { get; set; }


        public ShoppingCartDTO ShoppingCart { get; set; }
    }
}

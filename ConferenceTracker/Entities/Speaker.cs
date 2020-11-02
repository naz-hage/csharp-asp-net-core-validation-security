using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferenceTracker.Entities
{
    public class Speaker
    {
        [Required()]
        public int Id { get; set; }

        [Required()]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 2,
        ErrorMessage = "* First name must be between 2 and 100 characters in length.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required()]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 2,
        ErrorMessage = "* Last name must be between 2 and 100 characters in length.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required()]
        [DataType(DataType.MultilineText)]
        [StringLength(500, MinimumLength = 10,
        ErrorMessage = "* Description must be between 10 and 500 characters in length.")]
        public string Description { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        
        public bool IsStaff { get; set; }
    }
}

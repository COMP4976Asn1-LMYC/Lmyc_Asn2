using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LmycWeb.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100, MinimumLength = 1, ErrorMessage = "First Name have to be between 1 to 100 charater")]
        [Required(ErrorMessage = "First Name field is required.")]
        [DataType(DataType.Text)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [StringLength(100, MinimumLength = 1, ErrorMessage = "Last Name have to be between 1 to 100 charater")]
        [Required(ErrorMessage = "Last Name field is required.")]
        [DataType(DataType.Text)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [StringLength(100, MinimumLength = 1, ErrorMessage = "Street field must be between 1 & 100 characters")]
        [Required(ErrorMessage = "Street field is required.")]
        [DataType(DataType.Text)]
        public string Street { get; set; }

        [StringLength(100, MinimumLength = 1, ErrorMessage = "City field must be between 1 & 100 characters")]
        [Required(ErrorMessage = "Street field is required.")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required(ErrorMessage = "Postal code field is required.")]
        [DataType(DataType.Text)]
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Province field is required.")]
        [DataType(DataType.Text)]
        [DisplayName("Province")]
        public string Province { get; set; }

        [StringLength(100, MinimumLength = 1, ErrorMessage = "Country must be between 1 & 100 characters")]
        [Required(ErrorMessage = "Country field is required.")]
        [DataType(DataType.Text)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [DisplayName("Mobile Phone")]
        [Phone]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Your sailing experience is needed.")]
        [DisplayName("Sailing Experience")]
        public int SailingExperience { get; set; }

        }
}
using System.ComponentModel.DataAnnotations;

namespace VehicleTrader.Core.Dto
{
    public class UserRegistrationDto
    {
        /// <summary>
        /// Email new user
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        /// Password new user
        /// </summary>
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        /// <summary>
        /// Confirm password new user
        /// </summary>
        [Required]
        public string ConfirmPassword { get; set; }
        /// <summary>
        /// First name new user
        /// </summary>
        [Required]
        [StringLength(64, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string FirstName { get; set; }
        /// <summary>
        /// Last name new user
        /// </summary>
        [Required]
        [StringLength(64, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string LastName { get; set; }
        /// <summary>
        /// User name
        /// </summary>
        public string UserName { get; set; }
    }
}
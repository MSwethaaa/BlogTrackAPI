using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlogTrackAPI.Models
{

        [Table("AdminInfo")]
        public class AdminInfo
        {
            [Key]
            [Required(ErrorMessage = "The EmailId field is required.")]
            [EmailAddress(ErrorMessage = "The EmailId field is not a valid e-mail address.")]
            public string? EmailId { get; set; }
            [Required(ErrorMessage = "The Password field is required.")]
            public string? Password { get; set; }
        }
    
}

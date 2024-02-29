using System.ComponentModel.DataAnnotations;

namespace BlogWebAppMVC.Models
{
    public class EmpLogin
    {
        [Required]
        [EmailAddress]
        public string? EmailId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public int PassCode { get; set; }
    }
}

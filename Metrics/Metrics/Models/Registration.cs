using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    public class Registration
    {
        [Key]
        public int RegistrationId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage ="This field is required.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Gender")]
        public string Gender { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Age")]
        public int Age { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Email Address")]
        [RegularExpression(@"^([\w-\.]+)@((\[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",ErrorMessage="Please enter valid EmailAddress")]
        public string EmailAddress { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Password")]
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("ConfirmPassword")]
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public int Level { get; set; }


        

        
    }
}

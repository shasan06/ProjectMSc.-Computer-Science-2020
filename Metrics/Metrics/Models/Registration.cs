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
        public string EmailAddress { get; set; }

        

        
    }
}

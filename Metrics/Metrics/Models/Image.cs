using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Models
{
    public class Image
    {

        [Key]
        public int ImageId { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ImageName { get; set; }

        
        //THE NAVIGATIONS ARE NOT NEEDED, DELETE!
        //navigation property
        //public Complexity Complexity { get; set; }
        //
        //public Registration Registration { get; set; }
        //
        //public Response Response { get; set; }
    }
}

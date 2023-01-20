using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class GenderModel
    {
        public int id { get; set; }

        [Required(ErrorMessage ="gender name is required")]
        public string Name { get; set; }
        public bool isactive { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> modifieddate { get; set; }
        public Nullable<int> modifiedby { get; set; }
    }
}

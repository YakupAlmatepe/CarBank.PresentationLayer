using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBank.EntityLayer1.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public String CategoryName { get; set; }
        public String CategoryLogo { get; set; }
        [StringLength(50)]
        public String CategoryDescription { get; set; }
    }
}

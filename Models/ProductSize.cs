using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code.Models
{
    public class ProductSize
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int SizeId { get; set; }
        public virtual Size Size { get; set; }
    }
}

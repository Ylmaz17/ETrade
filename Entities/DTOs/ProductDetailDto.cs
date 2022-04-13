using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto : IDTo
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName1 { get; set; }
        public int Stock { get; set; }
    }
}

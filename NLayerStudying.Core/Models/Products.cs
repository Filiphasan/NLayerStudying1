using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerStudying.Core.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public string InnerBarcode { get; set; }
        public virtual Categories Categories { get; set; }
    }
}

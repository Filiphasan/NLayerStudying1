using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NLayerStudying.Core.Models
{
    public class Categories
    {
        public Categories()
        {
            Products = new Collection<Products>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}

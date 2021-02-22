using NLayerStudying.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerStudying.Core.Repositories
{
    public interface IProductRepository:IRepository<Products>
    {
        Task<Products> GetWithCategoryByIdAsync(int productId);
    }
}

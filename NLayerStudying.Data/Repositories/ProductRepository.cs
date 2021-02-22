using Microsoft.EntityFrameworkCore;
using NLayerStudying.Core.Models;
using NLayerStudying.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerStudying.Data.Repositories
{
    public class ProductRepository : Repository<Products>, IProductRepository
    {
        private AppDbContext appContext { get => _context as AppDbContext; }
        public ProductRepository(DbContext context) : base(context)
        {
        }

        public async Task<Products> GetWithCategoryByIdAsync(int productId)
        {
            return await appContext.Products.Include(x => x.Categories).SingleOrDefaultAsync(x => x.Id==productId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using NLayerStudying.Core.Models;
using NLayerStudying.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerStudying.Data.Repositories
{
    public class CategoryRepository : Repository<Categories>, ICategoryRepository
    {
        private AppDbContext appContext { get => _context as AppDbContext; }
        public CategoryRepository(DbContext context) : base(context)
        {
        }

        public async Task<Categories> GetWithProductsByIdAsync(int categoryId)
        {
            return await appContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}

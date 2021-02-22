using NLayerStudying.Core.Repositories;
using NLayerStudying.Core.UnitOfWork;
using NLayerStudying.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerStudying.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IProductRepository Product => _productRepository=_productRepository ?? new ProductRepository(_context);

        public ICategoryRepository Category => _categoryRepository=_categoryRepository ?? new CategoryRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
             await _context.SaveChangesAsync();
        }
    }
}

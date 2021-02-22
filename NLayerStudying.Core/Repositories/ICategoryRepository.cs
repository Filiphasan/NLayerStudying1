using NLayerStudying.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerStudying.Core.Repositories
{
    public interface ICategoryRepository:IRepository<Categories>
    {
        Task<Categories> GetWithProductsByIdAsync(int categoryId);
    }
}

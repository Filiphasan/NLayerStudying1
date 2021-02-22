using NLayerStudying.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerStudying.Core.Services
{
    public interface ICategoryService:IService<Categories>
    {
        Task<Categories> GetWithProductsByIdAsync(int categoryId);
    }
}

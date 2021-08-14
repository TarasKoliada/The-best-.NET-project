using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestShop.Domain.Entities;

namespace TheBestShop.Contractors.Abstractions
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product GetById(int id);
        List<Product> GetAll();
        bool Delete(Product product);
        bool Delete(int id);
    }
}

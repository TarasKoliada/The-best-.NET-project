using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestShop.Domain.Entities;
using TheBestShop.Contractors.Abstractions;



namespace TheBestShop.BusinessLogic.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> productList = new List<Product>();
        public void Add(Product product)
        {
            product.Id++;
            productList.Add(new Product() { Name = product.Name, Price = product.Price, Id = product.Id });
        }

        //Not Implemented
        public bool Delete(Product product)
        {
            throw new NotImplementedException();
        }
        //

        public bool Delete(int id)
        {
            var deleteProduct = productList.FirstOrDefault(prod => prod.Id == id);
            if (deleteProduct == null)
            {
                return false;
            }
            else
            {
                productList.Remove(deleteProduct);
                return true;
            }
        }

        public List<Product> GetAll()
        {
            return productList;
        }

        public Product GetById(int id)
        {
            Product p = new Product();
            foreach (var item in productList)
            {
                if (item.Id == id)
                {
                    p.Name = item.Name;
                    p.Price = item.Price;
                    p.Id = item.Id;
                    return p;
                }
            }
            return null;
            
        }
    }
}

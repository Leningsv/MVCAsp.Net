using MVCWebApi.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models.Services
{
    public class ProductService : IProductService
    {
        private ProductEntities db = new ProductEntities();

        public Product GetProduct(int id)
        {
            return (db.Product.Where(item => item.Id == id)).FirstOrDefault();
        }
        public List<Product> GetProducts()
        {
            return db.Product.ToList();
        }
    }
}
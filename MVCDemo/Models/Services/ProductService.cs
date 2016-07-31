using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.Models.DataBase;

namespace MVCDemo.Models.Services
{
    public class ProductService : IProductService
    {
        private ProductEntities db = new ProductEntities();
        public List<Product> GetProducts()
        {
            return db.Product.ToList();
        }
    }
}
using MVCWebApi.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Models.Services
{
    public class ProductService : IProductService
    {
        private ProductEntities db = new ProductEntities();

        public bool DeleteProduct(int id)
        {
            try
            {
                //var product = db.Product.Where(item => item.Id == id).FirstOrDefault();
                var product = db.Product.Single(item => item.Id == id);
                if (product != null)
                {
                    db.Entry(product).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                return false;                              
            }
            catch
            {
                return false;
            }
        }

        public Product GetProduct(int id)
        {
            return (db.Product.Where(item => item.Id == id)).FirstOrDefault();
        }
        public List<Product> GetProducts()
        {
            return db.Product.ToList();
        }

        public bool InsertProduct(Product product)
        {
            try
            {
                db.Entry(product).State = EntityState.Added;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
         
        public bool UpdateProduct(Product product)
        {
            try
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
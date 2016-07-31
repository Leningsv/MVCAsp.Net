using MVCWebApi.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Models.Services
{
    interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        Boolean InsertProduct(Product product);
        Boolean UpdateProduct(Product product);
        Boolean DeleteProduct(int id);
    }
}

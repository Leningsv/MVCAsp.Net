using MVCDemo.Models.Services;
using MVCWebApi.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApi.Controllers
{
    public class ProductV1Controller : ApiController
    {
        private ProductService productService = new ProductService();
        public IEnumerable<Product> GetProducts()
        {
            return productService.GetProducts();
        }
    }
}

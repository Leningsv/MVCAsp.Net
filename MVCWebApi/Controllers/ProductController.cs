using MVCDemo.Models.Services;
using MVCWebApi.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApi.Controllers
{
    public class ProductController : Controller
    {
        private ProductService productService = new ProductService();
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult List()
        {
            ViewBag.Products = productService.GetProducts();
            ViewData["ListProducts"] = productService.GetProducts();
            return View(productService.GetProducts());
        }
        //En caso de varios parametros  ?name=Lenin
        public ViewResult Details(int id)
        {
            Product product = productService.GetProduct(id);
            return View(product);
        }
        public ViewResult Create(Product product)
        {
            productService.InsertProduct(product);
            return View(product);
        }
        public ViewResult Edit(Product product)
        {
            productService.UpdateProduct(product);
            return View(product);
        }
        public ViewResult Delete(Product product)
        {
            productService.DeleteProduct(product.Id);
            return View(product);
        }
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitnessServices.BusinessLogic;
using FitnessServices.BusinessLogic.Interfaces;

namespace FitnessServices.web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private readonly IProduct _productBL;
        public ProductController()
        {
               BusinessLogic.BusinessLogic bl = new BusinessLogic.BusinessLogic();
               _productBL = bl.GetProductBL();

        }
        public ActionResult Index()
        {
             _productBL.GetProductByID(1);
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessServices.BusinessLogic.Core;
using FitnessServices.BusinessLogic.Interfaces;

namespace FitnessServices.BusinessLogic
{
     public class ProductBL: UserApi, IProduct
     {
          public string GetProductByID(int id)
          {
               return GetProduct(id);
          }
     }
}

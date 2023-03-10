using FitnessServices.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessServices.BusinessLogic.Core
{
     public class UserApi
     {
          public string UserAsignCookies(ULoginData loginData)
          {
               return "cookies";
          }

          public bool UserCookiesValidator(string cookies)
          {
               return true;
          }

          public string GetProduct(int id)
          {
               return "product";
          }

     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessServices.BusinessLogic.Core;
using FitnessServices.BusinessLogic.Interfaces;
using FitnessServices.Domain.Entities.User;

namespace FitnessServices.BusinessLogic
{
     public class SessionBL : UserApi, ISession
     {
          public string GetCookies(ULoginData loginData)
          {
               return UserAsignCookies(loginData);
          }

          public bool ValidateCookies(string cookies)
          {
               return UserCookiesValidator(cookies);
          }
     }
}

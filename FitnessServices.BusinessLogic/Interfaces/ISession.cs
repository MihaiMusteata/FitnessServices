using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessServices.Domain.Entities.User;

namespace FitnessServices.BusinessLogic.Interfaces
{
     public interface ISession
     {
          string GetCookies(ULoginData loginData);
          bool ValidateCookies(string cookies);
     }
}

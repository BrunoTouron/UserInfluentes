using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using System.Web.Mvc;
using UserInfluentes.data;
using UserInfluentes.Bus;

namespace UserInfluentes.Controllers
{
    public class UsersApiController : ApiController
    {
        public IEnumerable<__Interactions> GetInteractions()
        {
            var usersBO = new UsersBO();

            usersBO.GetBrands();
            usersBO.GetUsers();
            usersBO.Get_Interactions();            

            return usersBO.GetInteractions();
        }
    }
}
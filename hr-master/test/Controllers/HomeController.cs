using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using test.Models;

namespace test.Controllers
{
    public class HomeController : ApplicationBaseController
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize(Roles = "Admin,Standart")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
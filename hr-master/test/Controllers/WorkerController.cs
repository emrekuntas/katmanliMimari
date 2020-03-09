using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class WorkerController : Controller
    {
        // GET: Worker
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WorkerDetail()
        {
            return View();
        }
        public ActionResult ListOfWorkers()
        {
            return View();
        }
        public ActionResult newWorker()
        {
            return View();
        }
    }
}
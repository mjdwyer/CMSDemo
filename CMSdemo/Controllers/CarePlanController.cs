using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSdemo.Controllers
{
    public class CarePlanController : Controller
    {
        //
        // GET: /CarePlan/

        public ActionResult CarePlan()
        {
            return View();
        }

        public ActionResult CarePlanCMIssues()
        {
            return View();
        }

        public ActionResult CarePlanCMIssueEdit()
        {
            return View();
        }

    }
}

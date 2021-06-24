using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _410637015.Controllers
{
    public class SundayController : Controller
    {
        // GET: Sunday
        public ActionResult Index(int? inp)
        {
            var result = "";
            if (inp == 1)
            {
                result = "星期一";
            }
            if (inp == 2)
            {
                result = "星期二";
            }
            if (inp == 3)
            {
                result = "星期三";
            }
            if (inp == 4)
            {
                result = "星期四";
            }
            if (inp == 5)
            {
                result = "星期五";
            }
            if (inp == 6)
            {
                result = "星期六";
            }
            if (inp == 7)
            {
                result = "星期日";
            }
            ViewBag.Result = result;
            return View();
        }

    }
}
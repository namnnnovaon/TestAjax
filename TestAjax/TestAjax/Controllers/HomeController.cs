using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAjax.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string checkEmail(String email)
        {
            string val = "";
            if (email.Contains("@"))
            {
                if (email.Contains(".com"))
                {
                    val = "correct";
                }
            }
            else
            {
                val= "incorrect";
            }
            return val;
        }
    }
}

using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410919946.Controllers
{
    public class MusicNoteController : Controller
    {
        // GET: MusicNote
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name,string note)
        {
            int n = Int32.Parse(note);
            if (n == 1) note = "do";
            if (n == 2) note = "re";
            if (n == 3) note = "mi";
            if (n == 4) note = "fa";
            if (n == 5) note = "so";
            if (n == 6) note = "la";
            if (n == 7) note = "xi";
            if (!name.IsNullOrWhiteSpace())
            {
                if (n < 1 || n > 7)
                {
                    ViewBag.Message = "Hi, " + name + "," + " 查詢音符為:錯誤";
                }
                else
                {
                    ViewBag.Message = "Hi, " + name + "," + " 查詢音符為:" + note;
                }
            }
            
            return View();
        }
    }
}
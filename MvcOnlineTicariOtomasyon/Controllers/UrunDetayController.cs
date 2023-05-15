using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Context;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        // GET: UrunDetay
        MyContext c = new MyContext();

        public ActionResult Index()
        {
            UrunDetayListeleme cs = new UrunDetayListeleme();
            //var degerler = c.Uruns.Where(x => x.UrunID == 1).ToList();
            cs.Deger1 = c.Uruns.Where(x => x.UrunID == 1).ToList();
            cs.Deger2 = c.Detays.Where(y => y.DetayId == 1).ToList();
            return View(cs);
        }
    }
}
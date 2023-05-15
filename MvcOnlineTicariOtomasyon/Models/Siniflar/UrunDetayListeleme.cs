using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class UrunDetayListeleme
    {
        public virtual List<Urun> Deger1{ get; set; }
        public virtual List<Detay> Deger2 { get; set; }
    }
}
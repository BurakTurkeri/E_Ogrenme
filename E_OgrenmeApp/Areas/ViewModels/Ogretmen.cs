using E_OgrenmeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_OgrenmeApp.Areas.ViewModels
{
    public class HomeIndex
    {

        public IEnumerable<Ogretmenler> Ogretmen { get; set; }

    }
    public class HomeNew
    {
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string Branşı { get; set; }
    }

    public class HomeOgretmenListele
    {
        public IEnumerable<Ogretmenler> ogretmenler { get; set; }
    }

}
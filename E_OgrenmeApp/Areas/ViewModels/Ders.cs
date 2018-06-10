using E_OgrenmeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_OgrenmeApp.Areas.ViewModels
{
    public class AnasayfaIndex
    {
        public IEnumerable<Dersler> Ders { get; set; }
    }
    public class AnasayfaNew
    {
        public string DersAdı { get; set; }
        public string DersKonu { get; set; }
        public string Link { get; set; }
        public string Pdf { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SinavProje.Models;
using System.IO;
using System.Net;
using HtmlAgilityPack;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;

namespace SinavProje.Controllers
{
    public class Sinav : Controller
    {

        Context c = new Context();
        [Authorize]

        [HttpGet]
        public IActionResult Index()
        {
            List<SelectListItem> deger = new List<SelectListItem>() { new SelectListItem { Text = "Deneme", Value = "1" } };
            ViewBag.dg5 = deger;

            var deger1 = c.SoruDetays.Where(y => y.ID == 1).Select(x => x.SoruMetin);
            ViewBag.dg4 = deger1;
            return View();
        }

        [HttpPost]
        public IActionResult Index(SorularDetay s)
        {
            s.Durum = 1;
            s.Tarih = DateTime.Now.ToString();
            c.SoruDetays.Add(s);
            c.SaveChanges();
            return RedirectToAction("yeniSinav");
        }


        public IActionResult YeniSinav()
        {
            var deger = c.SoruDetays.Where(x => x.Durum == 1).ToList();
            return View(deger);
        }
        public IActionResult SinavSil(int id)
        {
            var deger = c.SoruDetays.Find(id);
            deger.Durum = 0;
            c.SaveChanges();
            return RedirectToAction("YeniSinav");
        }
        public IActionResult Sinavlist()
        {
            var deger = c.SoruDetays.Where(x => x.Durum == 1).ToList();
            return View(deger);

        }

        public IActionResult SinavCöz(int id)
        {
            var list = c.SoruDetays.Where(x=>x.ID==id).ToList();
            return View(list);
           
        }
        public IActionResult SinavSonuc()
        {
            return View();
        }
        public JsonResult SinavSonuc(int id)
        {
            var list = c.SoruDetays.Where(x => x.ID == id).ToList();
            return Json(list);
        }
        public IActionResult VeriCek(SorularDetay s)
        {
           
            return View();
        }
    }
}

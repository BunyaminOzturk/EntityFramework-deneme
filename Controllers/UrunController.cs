using AspNetMVC_020_EntityFramework.DAL;
using AspNetMVC_020_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_020_EntityFramework.Controllers
{
    public class UrunController : Controller
    {
        SatisContext veritabani = new SatisContext();
        public ActionResult Index()
        {
            List<Urun> urunler = veritabani.Urunler.ToList();
            return View(urunler);
        }
        public ActionResult Kategori(int id)
        {
            //Kategori adını veritabanından alan sorgu
            string kategoriAdi = (from k in veritabani.Kategoriler
                                  where k.Id == id
                                  select k.Ad).FirstOrDefault();
            //kategori adını View ın başlığı olarak tanımlama
            ViewBag.Title = kategoriAdi + "Kategorisindeki Ürünler";

            //Kategorinin ID değerini Viewbag ile view a gönderme
            ViewBag.Id = id;

            //Kategorideki ürünleri veritabanından alan sorgu
            List<Urun> urunler = (from u in veritabani.Urunler
                                  where u.KategoriId == id
                                  select u).ToList();
            return View(urunler);
        }
        public ActionResult Detay(int id)
        {
            //ürün bilgilerini vertabanından alan sorgu
            Urun urun = (from u in veritabani.Urunler
                         where u.Id == id
                         select u).FirstOrDefault();
            return View(urun);
        }
        public ActionResult Yeni()
        {
            //Veritabanındaki tüm kategori bilgilerini SelectListItem türünden liste ile alan sorgu
            var kategoriler = veritabani.Kategoriler.ToList().Select(k => new SelectListItem
            {
                Selected = false,
                Text = k.Ad,
                Value = k.Id.ToString()
            }).ToList();

            //Kategori Listesini ViewBag ile View a gönderiyoruz
            ViewBag.Kategoriler = kategoriler;

            return View();
        }

    }
}
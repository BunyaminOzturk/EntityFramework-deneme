using AspNetMVC_020_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVC_020_EntityFramework.DAL
{
    public class SatisInitializer : System.Data.Entity.CreateDatabaseIfNotExists<SatisContext>
    {
        protected override void Seed(SatisContext context)
        {
            var kategoriBilgisayar = new Kategori { Ad = "Bilgisayar" };
            var kategoriCepTelefonu = new Kategori { Ad = "Cep Telefonu" };
            var kategoriTelevizyon = new Kategori { Ad = "Televizyon" };
            context.Kategoriler.Add(kategoriBilgisayar);
            context.Kategoriler.Add(kategoriCepTelefonu);
            context.Kategoriler.Add(kategoriTelevizyon);
            context.SaveChanges();

            List<Urun> urunler = new List<Urun>
            {
                new Urun { Ad = "Notebook", Fiyat = 2000, KategoriId = kategoriBilgisayar.Id,
                    Stok = 300},
                new Urun { Ad = "Tablet Pc", Fiyat = 800, KategoriId = kategoriBilgisayar.Id,
                    Stok = 450},
                new Urun { Ad = "Masaüstü PC", Fiyat = 1500, KategoriId = kategoriBilgisayar.Id,
                    Stok = 150},
                new Urun { Ad = "Ultrabook", Fiyat = 3000, KategoriId = kategoriBilgisayar.Id,
                    Stok = 85},
                new Urun { Ad = "Smartphone", Fiyat = 2000, KategoriId = kategoriBilgisayar.Id,
                    Stok = 1000},
                new Urun { Ad = "Tabphone", Fiyat = 3000, KategoriId = kategoriBilgisayar.Id,
                    Stok = 50},
                new Urun { Ad = "Led TV", Fiyat = 3500, KategoriId = kategoriBilgisayar.Id,
                    Stok = 50},
                new Urun { Ad = "LCD TV", Fiyat = 1100, KategoriId = kategoriBilgisayar.Id,
                    Stok = 30},
                new Urun { Ad = "Plazma TV", Fiyat = 2250, KategoriId = kategoriBilgisayar.Id,
                    Stok = 20},
            };
            urunler.ForEach(urun => context.Urunler.Add(urun));
            context.SaveChanges();
        }
    }
    
}
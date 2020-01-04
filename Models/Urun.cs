using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVC_020_EntityFramework.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public int Stok { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
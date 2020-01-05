using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AspNetMVC_020_EntityFramework.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }

        [DisplayName("Ürün Adı")]
        public string Ad { get; set; }

        [DisplayName("Fiyatı")]
        public double Fiyat { get; set; }

        [DisplayName("Stok Miktarı")]
        public int Stok { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
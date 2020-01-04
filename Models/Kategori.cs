using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVC_020_EntityFramework.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public virtual ICollection<Urun> Urunler { get; set; }
    }
}
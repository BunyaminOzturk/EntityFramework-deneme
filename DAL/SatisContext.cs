using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Data;
using System.Data.Entity;
using AspNetMVC_020_EntityFramework.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AspNetMVC_020_EntityFramework.DAL
{
    public class SatisContext : DbContext
    {
        public SatisContext() : base("SatisVeriTabani") {}
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
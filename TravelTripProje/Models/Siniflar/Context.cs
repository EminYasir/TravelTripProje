﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProje.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims{ get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Otel> Otels { get; set; }
        public DbSet<OtelYorumlar> OtelYorumlars { get; set; }
        public DbSet<Muze> Muzes { get; set; }
        public DbSet<MuzeYorumlar> MuzeYorumlars { get; set; }

    }
}
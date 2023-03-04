﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class OtelYorumlar
    {
        [Key]
        public int ID { get; set; }
        public string Kullaniciadi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Otelid { get; set; }
        public virtual Otel Otel { get; set; }
    }
}
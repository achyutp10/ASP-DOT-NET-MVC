using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StronglyTypedPartialView.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string picture { get; set; }
    }
}
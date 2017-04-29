using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task12.Models
{
    public class Towar
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public string url { get; set; }
    }
}
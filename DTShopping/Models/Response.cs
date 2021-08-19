﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTShopping.Models
{
    public class Response
    {

        public bool Status { get; set; }
        public string ResponseValue { get; set; }
        public object Url { get; set; }
        public double Points { get; set; }
        public double TotalRecords { get; set; }
        public int CartProductCount { get; set; }
         public string totalPoints { get; set; }
         public decimal hwallet { get; set; }


    }
    public class ResponseBuyPackage
    {
        public string status { get; set; }
        public string response { get; set; }
    }
}
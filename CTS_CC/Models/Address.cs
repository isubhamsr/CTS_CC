﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTS_CC.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
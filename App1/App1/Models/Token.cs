﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Token
    {
        public int Id { get; set; }
        public string access_token { get; set; }
        public string errorMessage { get; set; }
        public DateTime expire_date { get; set; }

        public Token() { }
    }
}

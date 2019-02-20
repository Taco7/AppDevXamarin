using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Meeting
    {
        public int id { get; set; }
        public string agenda { get; set; }
        public DateTime date { get; set; }
        public List<User> attendes { get; set; }


    }
}

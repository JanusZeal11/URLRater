using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sunlight_WebDev_Evaulation__URLRater.Models
{
    public class URL
    {
        public Int32 Id { get; set; }
        public String Url { get; set; }
        public Int32 Votes { get; set; }
    }
}
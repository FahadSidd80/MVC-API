using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAp_MVC_API_USE_Consume_hit.Models
{
    public class tblEmployee
    {
        public int empid { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public Nullable<int> age { get; set; }
    }
}
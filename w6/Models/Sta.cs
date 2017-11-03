using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace w6.Models
{
    public class Sta
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
        public string Abbr { get; set; }
    }
}
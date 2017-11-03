using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace w6.Models
{
    public class User
    {
        public int Id { get; set; }

       // [Required, StringLength(maximumLength: 250)]
        public virtual string Name { get; set; }
        public byte[] Image { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        [Display(Name ="Is Person Married")]
        public virtual bool IsPersonMarried { get; set; }
        [Required, Display(Name = "State")]
        public int Sta { get; set; }

        [Required, Display(Name = "City")]
        public int Ct { get; set; }


    }
}
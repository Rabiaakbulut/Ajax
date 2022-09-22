using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ajax.Models
{
    public class userModel
    {
        public string fullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public int age { get; set; }
        public string city { get; set; }
    }
}
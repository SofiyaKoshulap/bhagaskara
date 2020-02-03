using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bhagaskara.Models
{
    public class Feedback
    {
        public int Id { get; set; }
       
        public string name { get; set; }
      
        public string email { get; set; }
  
        public string message { get; set; }
    }
}
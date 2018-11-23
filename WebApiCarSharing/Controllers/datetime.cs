using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCarSharing.Controllers
{
    public class datetime
    {
        public DateTime date()
        {
            DateTime date = new DateTime();
            date = DateTime.Today;
            return date;

        }
    }
    
}
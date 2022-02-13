using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeWidgetAPI
{
    public class ActivitySignUpForm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Activity Activity { get; set;  }
        public string Comments { get; set; }
    }

    public enum Activity
    {
        Singing  = 1,
        Dancing = 2,
        Painting = 3
    }
}


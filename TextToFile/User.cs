using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToFile
{
    
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string City { get; set; }
        public string Faculty { get; set; }
        public Role Role { get; set; }
        public string RoleSpecificAttribute { get; set; }
    }
}

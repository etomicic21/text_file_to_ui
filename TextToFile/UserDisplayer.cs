using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToFile
{
    public class UserDisplayer
    {
        public User CurrentUser { get; set; }
        public string FullName { get; set; }
        public string YearOfBirth { get; set; }
        public string City { get; set; }
        public string Faculty { get; set; }
        public string Role { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public UserDisplayer(string path)
        {
            var userParser = new UserParser();
            CurrentUser = userParser.getUser(path);
            FullName = CurrentUser.FirstName + " " + CurrentUser.LastName;
            YearOfBirth = CurrentUser.YearOfBirth.ToString();
            City = CurrentUser.City.ToString();
            Faculty = CurrentUser.Faculty.ToString();
            Role = CurrentUser.Role.CurrentRole.ToString();
            AttributeName = CurrentUser.Role.GetAttribute();
            AttributeValue = CurrentUser.RoleSpecificAttribute.ToString();
        }
    }
}

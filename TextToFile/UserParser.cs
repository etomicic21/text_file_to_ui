using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TextToFile
{
    public class UserParser
    {
        public User getUser(string path)
        {
            var userFileReader = new UserFileReader();
            var userString = userFileReader.ReadFile(path);
            Dictionary<string, string> data = new Dictionary<string, string>();
            var split = userString.Split('\n');
            foreach (var line in split)
            {
                var lineSplit = line.Split('=');
                data.Add(lineSplit[0], lineSplit[1]);
            }
            var firstName = string.Empty;
            var lastName = string.Empty;
            var yearOfBirth = string.Empty;
            var city = string.Empty;
            var faculty = string.Empty;
            var roleString = string.Empty;
            var attributeString = string.Empty;
            data.TryGetValue("Ime", out firstName);
            data.TryGetValue("Prezime", out lastName);
            data.TryGetValue("Godina rođenja", out yearOfBirth);
            data.TryGetValue("Grad rođenja", out  city);
            data.TryGetValue("Fakultet", out faculty);
            data.TryGetValue("Uloga", out roleString);
            var userRole = new Role(roleString);
            var attribute = userRole.GetAttribute();
            data.TryGetValue(attribute, out attributeString);

            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                YearOfBirth = int.Parse(yearOfBirth),
                City = city,
                Faculty = faculty,
                Role = userRole,
                RoleSpecificAttribute = attributeString
            };

            return user;
        }
    }
}

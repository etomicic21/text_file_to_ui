using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToFile
{
    public enum Roles
    {
        student,
        Asistent
    }
    public class Role
    {
        public Roles CurrentRole { get; set; }
        private Dictionary<Roles, string> roles;

        public Role(string role)
        {
            CurrentRole = (Roles)Enum.Parse(typeof(Roles), role);
            roles = new Dictionary<Roles, string>();
            FillDictionary();
        }

        private void FillDictionary()
        {
            roles.Add(Roles.student, "Najdraži kolegij");
            roles.Add(Roles.Asistent, "Katedra");
        }

        public string GetAttribute()
        {
            var attribute = string.Empty;
            roles.TryGetValue(this.CurrentRole, out attribute);
            return attribute;
        }
    }
}

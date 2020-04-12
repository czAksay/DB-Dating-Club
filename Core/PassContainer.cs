using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    public static class PassContainer
    {
        public static String GetRolePasswordByRoleName(String role)
        {
            if (role == "financer")
                return "abyfycjdobr";
            else if (role == "admin")
                return "mrkqjudiadpqkqrjfqrj";
            else if (role == "manager")
                return "bnjvfyfluth";
            else if (role == "formworker")
                return "fyrtnjkju";
            else
                return role;
        }
    }
}

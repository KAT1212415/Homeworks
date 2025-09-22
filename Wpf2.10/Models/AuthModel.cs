using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2._10
{
    internal class AuthModel
    {

        string ValidUsername = "admin";
        string ValidPassword = "12345";

        static bool Authenticate(string username, string password, bool bool1)
        {
            if (username == ValidUsername && password== ValidPassword) { return true; }
            else
            {
                return false;
            }
        }
    }
}


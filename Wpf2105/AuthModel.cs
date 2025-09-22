using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2105
{
   public class AuthModel
    {
        static public bool Authenticate(string username, string password)

        { return username == "admin" && password == "12345"; }

    }
}

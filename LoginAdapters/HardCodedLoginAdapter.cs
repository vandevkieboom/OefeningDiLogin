using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAdapters
{
    public class HardCodedLoginAdapter : ILogin
    {
        public bool Login(string username, string password)
        {
            if (username == "Admin" && password == "abc123")
            {
                return true;
            }
            return false;
        }
    }
}

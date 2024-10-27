using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAdapters
{
    public class AlwaysLoginAdapter : ILogin
    {
        public bool Login(string username, string password)
        {
            return true;
        }
    }
}

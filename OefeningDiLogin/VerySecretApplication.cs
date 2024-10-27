using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningDiLogin
{
    public class VerySecretApplication
    {
        private readonly ILogin _login;

        public VerySecretApplication(ILogin login)
        {
            _login = login;
        }

        public void Start()
        {
            Console.Write("username: ");
            string username = Console.ReadLine();

            Console.Write("password: ");
            string password = Console.ReadLine();

            bool isLoggedIn = _login.Login(username, password);
            if (isLoggedIn)
            {
                Console.WriteLine("starting..");
            }
            else
            {
                Console.WriteLine("username or password incorrect!");
            }
        }
    }
}

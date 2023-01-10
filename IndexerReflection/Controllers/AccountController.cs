using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerReflection.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _service;
        public AccountController()
        {
            _service = new AccountService();
        }
        public void Register()
        {
            Console.WriteLine("Add usernssme:");
            string username = Console.ReadLine();
            Console.WriteLine("Add email:");
            string email = Console.ReadLine();
            Console.WriteLine("Add password:");
            string password = Console.ReadLine();
            var res = _service.Register(username, email, password);
            Console.WriteLine(res);
        }
    }
}

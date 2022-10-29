using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting_DownCasting_Boxing_Unboxing
{
    class AccountController
    {


        public void Login()
        {
            Console.WriteLine("Add email:");
            string email = Console.ReadLine();

            Console.WriteLine("Add password:");
            string password = Console.ReadLine();
            int role = 1;


            IAccountService account = new AccountService();
            var result = account.Login(email, password, role);
            Console.WriteLine(result);

        }
    }
}

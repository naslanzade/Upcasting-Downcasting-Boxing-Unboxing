using Service.Helpers.Constants;
using Service.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public string Login(string email, string password, int role)
        {
            if (email == AccountConstants.Email && password == AccountConstants.Password)
            {
                if (CheckRole(role))
                {
                    return AccountConstants.Success;
                }
                else
                {
                    return AccountConstants.NoAuthorize;
                }
            }
            return AccountConstants.Failed;

        }


        //private bool CheckRole(int role)
        //{
        //    switch (role)
        //    {
        //        case (int)Roles.SuperAdmin:
        //            return true;
        //        default:
        //            return false;
        //    }
        //}


        private bool CheckRole(int role)
        {
            if (role == (int)Roles.SuperAdmin)
            {
                return true;
            }
            return false;

        }
    }

   
}

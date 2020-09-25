using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserPL.Models
{
    public static class Auth
    {
        public static bool CanLogin(string login, string password) =>
            login == "admin" && password == "admin";
    }
}
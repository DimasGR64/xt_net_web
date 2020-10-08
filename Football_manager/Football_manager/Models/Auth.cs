using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Football_manager.Models
{
    public static class Auth
    {
        public static bool CanLoginCoach(string login, string password) =>
            login == "Yuri_Siomin" && password == "Loko";
        public static bool CanLoginMedic(string login, string password) =>
            login == "Medic" && password == "Loko";
    }
}
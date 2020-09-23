using BLL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Bll;

namespace User.BLL.Dependencies
{
    public static class UsersBLLDependencies
    {
        public static IUserBLL _usersBLL;
        public static IUserBLL UserBLL => _usersBLL?? (_usersBLL = new UserManager());
    }
}

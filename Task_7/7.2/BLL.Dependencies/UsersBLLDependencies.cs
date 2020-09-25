using BLL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.BLL;

namespace BLL.Dependencies
{
    public static class UsersBLLDependencies
    {
        public static IUserBLL _usersBLL;
        public static IUserBLL UserBLL => _usersBLL ?? (_usersBLL = new UserManager());

        public static IAwardBLL _awardBLL;
        public static IAwardBLL AwardBLL => _awardBLL ?? (_awardBLL = new UserManager());
    }
}

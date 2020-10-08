using PL.Common;
using PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Dependencies
{
    public static class UsersPLDependencies
    {
        private static IUserPL _userPL;
        public static IUserPL UserPL => _userPL ?? (_userPL = new PLConsole());
    }
}

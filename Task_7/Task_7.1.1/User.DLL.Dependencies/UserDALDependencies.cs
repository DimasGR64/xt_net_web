using DAL;
using DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.DLL.Dependencies
{
    public class UserDALDependencies
    {
        public static IUserDAL _userDAL;
        public static IUserDAL UserDAL => _userDAL ?? (_userDAL = new JsonDAL());
    }
}

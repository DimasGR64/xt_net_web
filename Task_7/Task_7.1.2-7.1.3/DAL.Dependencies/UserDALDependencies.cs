using DALCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDAL;

namespace DAL.Dependencies
{
    public class UserDALDependencies
    {
        public static IUserDAL _userDAL;
        public static IUserDAL UserDAL => _userDAL ?? (_userDAL = new JsonDAL());

        public static IAwardDAL _awardDAL;
        public static IAwardDAL AwardDAL => _awardDAL ?? (_awardDAL = new JsonDAL());

    }
}

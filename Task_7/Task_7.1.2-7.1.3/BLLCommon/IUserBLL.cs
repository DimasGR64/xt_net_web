﻿using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Common
{
    public interface IUserBLL
    {
        bool AddUser(Users user);
        IEnumerable<Users> GetAllUser();
        Users GetUserByID(Guid id);
        bool DeleteUser(Guid id);
    }
}

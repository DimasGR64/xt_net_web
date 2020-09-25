﻿using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALCommon
{
    public interface IUserDAL
    {
        void AddUser(Users user);
        IEnumerable<Users> GetAllUsers();
        Users GetUserByID(Guid id);
        bool DeleteUser(Guid id);
    }
}

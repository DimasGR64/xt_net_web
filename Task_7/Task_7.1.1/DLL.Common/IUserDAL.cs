using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Entites;

namespace DAL.Common
{
    public interface IUserDAL
    {
        void AddUser(Users user);
        IEnumerable<Users> GetAllUsers();
        Users GetUserByID(Guid id);
        bool DeleteUser(Guid id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Entites;

namespace BLL.Common
{
    public interface IUserWithAwards
    {
        IEnumerable<UsersWithAwards> GetAllUser();
    }
}

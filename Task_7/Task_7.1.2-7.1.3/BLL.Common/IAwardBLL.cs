using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Common
{
    public interface IAwardBLL
    {
        Guid AddUser(Award user);
        IEnumerable<Award> GetAllUser();
        Award GetUserByID(Guid id);
        Award DeleteUser(Guid id);
    }
}

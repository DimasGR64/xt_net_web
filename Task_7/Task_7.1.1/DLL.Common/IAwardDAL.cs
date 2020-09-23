using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Entites;

namespace DLL.Common
{
    public interface IAwardDAL
    {
        Guid AddAward(Award award);
        IEnumerable<Award> GetAllAwards();
        Award GetAwardByID(Guid id);
        bool DeleteAward(Guid id);
    }
}

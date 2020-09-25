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
        bool AddAward(Award award);
        IEnumerable<Award> GetAllAward();
        Award GetAwardByID(Guid id);
        Award DeleteAward(Guid id);
    }
}